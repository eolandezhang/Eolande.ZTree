Ext.onReady(function () {

    var store = Ext.create('Ext.data.TreeStore', {
        root: {
            expanded: true
        },
        proxy: {
            type: 'ajax',
            url: 'api/ZTree/Get'
        }
    });
    var treePanel = Ext.create('Ext.tree.Panel', {
        id: 'tree-panel',
        title: 'Sample Layouts',
        region: 'north',
        split: true,
        height: 360,
        minSize: 150,
        rootVisible: false,
        autoScroll: true,
        store: store,
        listeners: {
            itemclick: function (thisTree, record, item, index, e, options) {
                console.log(item);
                if (record.get('leaf')) {
                    Ext.MessageBox.alert('YES', record.get('text'));
                }
            }
        }
    });
    
   
    var contentPanel = {
        id: 'content-panel',
        region: 'center', // this is what makes this panel into a region within the containing layout
        layout: 'card',
        margins: '2 5 5 0',
        activeItem: 0,
        border: true,
        html: '<p>content panel</p>'
    };
    var detailsPanel = {
        id: 'details-panel',
        title: 'Details',
        region: 'center',
        bodyStyle: 'padding-bottom:15px;background:#eee;',
        autoScroll: true,
        html: '<p class="details-info">When you select a layout from the tree, additional details will display here.</p>'
    };

    Ext.create('Ext.Viewport', {
        layout: 'border',
        title: 'Ext Layout Browser',
        items: [{
            layout: 'border',
            id: 'layout-browser',
            region: 'west',
            border: false,
            split: true,
            margins: '2 0 5 5',
            width: 290,
            minSize: 100,
            maxSize: 500,
            items: [treePanel, detailsPanel]
        },
            contentPanel
        ],
        renderTo: Ext.getBody()
    });




    //$.ajax({
    //    method: 'get',
    //    url: 'api/ZTree/Get',
    //    contentType: "application/json; charset=utf-8",
    //    success: function (data) {


    //    }
    //});

});