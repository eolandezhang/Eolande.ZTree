﻿$(function () {

    $.ajax({
        method: 'get',
        url: 'api/ZTree/Get',
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log(eval(data));
            $.fn.zTree.init($("#tree"), {
                view: {
                    showIcon: true,
                    showLine: true,
                    showTitle: true
                },
                data: {
                    simpleData: {
                        enable: true
                    },
                    key: {
                        title: "name"
                    }
                }
            }, eval(data));
        }
    });
    //$.getJSON('/api/ZTree/Get',
    //   function (data) {
    //       $.fn.zTree.init($("#tree"), {
    //           view: {
    //               showIcon: false,
    //               showLine: true,
    //               showTitle: true
    //           },
    //           data: {
    //               simpleData: {
    //                   enable: true
    //               },
    //               key: {
    //                   title: "title"
    //               }
    //           }
    //       }, eval(data));
    //       //var cid = $.request.queryString["mid"];
    //       //if (cid != null) {
    //       //    var treeObj = $.fn.zTree.getZTreeObj("tree_Doc");
    //       //    var node = treeObj.getNodeByParam("id", cid, null);
    //       //    if (node != null) {
    //       //        treeObj.selectNode(node);
    //       //    }
    //       //}
    //   });
});