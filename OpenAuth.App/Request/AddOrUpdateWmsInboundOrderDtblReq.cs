﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenAuth.Repository.Core;

namespace OpenAuth.App.Request
{
    /// <summary>
	/// 入库通知单明细
	/// </summary>
    [Table("WmsInboundOrderDtbl")]
    public partial class AddOrUpdateWmsInboundOrderDtblReq 
    {

        /// <summary>
        /// 入库通知单明细号
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 入库通知单号
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 含税单价
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 无税单价
        /// </summary>
        public decimal? PriceNoTax { get; set; }
        /// <summary>
        /// 是否收货中(0:非收货中,1:收货中)
        /// </summary>
        public bool InStockStatus { get; set; }
        /// <summary>
        /// 到货状况(SYS_GOODSARRIVESTATUS)
        /// </summary>
        public int AsnStatus { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string GoodsId { get; set; }
        /// <summary>
        /// 商品批号
        /// </summary>
        public string GoodsBatch { get; set; }
        /// <summary>
        /// 品质(SYS_QUALITYFLAG)
        /// </summary>
        public string QualityFlg { get; set; }
        /// <summary>
        /// 通知数量
        /// </summary>
        public decimal OrderNum { get; set; }
        /// <summary>
        /// 到货数量
        /// </summary>
        public decimal InNum { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public decimal LeaveNum { get; set; }
        /// <summary>
        /// 占用数量
        /// </summary>
        public decimal HoldNum { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProdDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public string ExpireDate { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal? TaxRate { get; set; }
        /// <summary>
        /// 货主编号
        /// </summary>
        public string OwnerId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}