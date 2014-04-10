using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.FreeChartSample.Models
{
    #region Line

    public class AMCLineChartViewModel
    {
        public string CategoryFieldName { get; set; }
        public string categoryAxisName { get; set; }
        public AMCLineChartDataProviderViewModel[] DataProviderList { get; set; }
    }

    public class AMCLineChartDataProviderViewModel
    {
        public string CategoryField { get; set; }
        public string categoryAxis { get; set; }
    }

    #endregion

    #region Area

    public class AMCAreaChartViewModel
    {
        public string CategoryFieldName { get; set; }
        public AMCAreaChartDataProviderViewModel[] DataProviderList { get; set; }
        public string CategoryAxisName { get; set; }
        public string CategoryAxis { get; set; }
        public AMCAreaChartValueAxisViewModel[] ValueAxisList { get; set; }
        public AMCAreaChartGuideViewModel[] GuideList { get; set; }
        public AMCAreaChartGraphViewModel[] GraphList { get; set; }
    }

    public class AMCAreaChartDataProviderViewModel
    {
        public string Field { get; set; }
        public string Value { get; set; }
    }

    public class AMCAreaChartValueAxisViewModel
    {
        public string Title { get; set; }
    }

    public class AMCAreaChartGuideViewModel
    {
        public string Label { get; set; }
    }

    public class AMCAreaChartGraphViewModel
    {
        public string Title { get; set; }
        public string ValueField { get; set; }
    }

    #endregion

    #region Bar

    public class AMCBarChartViewModel
    {
        public string CategoryFieldName { get; set; }
        public AMCBarChartDataProviderViewModel[] DataProviderList { get; set; }
        public string CategoryAxisName { get; set; }
        public string CategoryAxis { get; set; }
        public AMCBarChartValueAxisViewModel[] ValueAxisList { get; set; }
        public AMCBarChartGraphViewModel[] GraphList { get; set; }
    }

    public class AMCBarChartDataProviderViewModel
    {
        public string Field { get; set; }
        public string Value { get; set; }
    }

    public class AMCBarChartValueAxisViewModel
    {
        public string Title { get; set; }
    }

    public class AMCBarChartGraphViewModel
    {
        public string Title { get; set; }
        public string ValueField { get; set; }
    }

    #endregion

    #region Column

    public class AMCColumnChartViewModel
    {
        public string CategoryFieldName { get; set; }
        public AMCColumnChartDataProviderViewModel[] DataProviderList { get; set; }
        public string CategoryAxisName { get; set; }
        public string CategoryAxis { get; set; }
        public AMCColumnChartGraphViewModel[] GraphList { get; set; }
    }

    public class AMCColumnChartDataProviderViewModel
    {
        public string Field { get; set; }
        public string Value { get; set; }
    }

    public class AMCColumnChartGraphViewModel
    {
        public string Title { get; set; }
        public string ValueField { get; set; }
    }

    #endregion

}