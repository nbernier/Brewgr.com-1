using System;

namespace Brewgr.Web.Core.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("BjcpStyleUrlFriendlyName_2015")]
    public class BjcpStyleUrlFriendlyName
	{
		/// <summary>
		/// Gets or sets the SubCategoryId
		/// </summary>
		public string SubCategoryId { get; set; }

		/// <summary>
		/// Gets or sets the UrlFriendlyName
		/// </summary>
		public string UrlFriendlyName { get; set; }

		/// <summary>
		/// Gets or sets the BjcpStyle
		/// </summary>
		public BjcpStyle BjcpStyle { get; set; }
	}
}