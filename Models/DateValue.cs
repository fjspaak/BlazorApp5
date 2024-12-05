using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DateValue
{
    public int DateId { get; set; }

    public DateTime DateValue1 { get; set; }

    public string? DateName { get; set; }

    public string? DayName { get; set; }

    public string? MonthName { get; set; }

    public string? MonthCode { get; set; }

    public string? QuaterName { get; set; }

    public string? QuaterCode { get; set; }

    public int? DayNumberOfWeek { get; set; }

    public int? DayNumberOfMonth { get; set; }

    public int? DayNumberOfQuater { get; set; }

    public int? DayNumberOfYear { get; set; }

    public int? WeekNumberOfYear { get; set; }

    public int? MonthNumberOfYear { get; set; }

    public int? QuaterNumberOfYear { get; set; }

    public int? Year { get; set; }

    public int? WeekNumber { get; set; }

    public string? WeekName { get; set; }

    public int? YearOfWeekNumber { get; set; }

    public bool? IsLastDayOfMonth { get; set; }

    public bool? IsLastDayOfQuater { get; set; }

    public bool? IsLastDayOfYear { get; set; }

    public bool? IsWorkingDay { get; set; }

    public bool? IsPaymentDay { get; set; }

    public bool? IsHoliday { get; set; }

    public string? Event { get; set; }

    public string? FiscalPeriodCode { get; set; }

    public int? Period444Number { get; set; }

    public string? Period444Name { get; set; }

    public int? Period445Number { get; set; }

    public string? Period445Name { get; set; }

    public int? Quater445Number { get; set; }

    public string? Quater445Code { get; set; }

    public bool? IsDataLoadedCorrectly { get; set; }

    public bool? IsSelectable { get; set; }

    public int? NumberOfWorkingDaysInWeek { get; set; }

    public int? NumberOfWorkingDaysInMonth { get; set; }

    public int? NumberOfWorkingDaysInQuater { get; set; }

    public int? NumberOfWorkingDaysInYear { get; set; }

    public int? NumberOfWorkingDaysInPeriod444 { get; set; }

    public int? NumberOfWorkingDaysInPeriod445 { get; set; }

    public bool? IsWeekDay { get; set; }

    public bool? IsWeekendDay { get; set; }

    public bool? IsNonWorkingDay { get; set; }

    public int? BookDateId { get; set; }

    public int? WeekFirstAllDayId { get; set; }

    public int? WeekFirstWeekDayId { get; set; }

    public int? WeekFirstWorkingDayId { get; set; }

    public int? WeekFirstHoliDayId { get; set; }

    public int? WeekFirstWeekendDayId { get; set; }

    public int? WeekFirstNonWorkingDayId { get; set; }

    public int? CalendarMonthFirstAllDayId { get; set; }

    public int? CalendarMonthFirstWeekDayId { get; set; }

    public int? CalendarMonthFirstWorkingDayId { get; set; }

    public int? CalendarMonthFirstHoliDayId { get; set; }

    public int? CalendarMonthFirstWeekendDayId { get; set; }

    public int? CalendarMonthFirstNonWorkingDayId { get; set; }

    public int? CalendarQuarterFirstAllDayId { get; set; }

    public int? CalendarQuarterFirstWeekDayId { get; set; }

    public int? CalendarQuarterFirstWorkingDayId { get; set; }

    public int? CalendarQuarterFirstHoliDayId { get; set; }

    public int? CalendarQuarterFirstWeekendDayId { get; set; }

    public int? CalendarQuarterFirstNonWorkingDayId { get; set; }

    public int? CalendarYearFirstAllDayId { get; set; }

    public int? CalendarYearFirstWeekDayId { get; set; }

    public int? CalendarYearFirstWorkingDayId { get; set; }

    public int? CalendarYearFirstHoliDayId { get; set; }

    public int? CalendarYearFirstWeekendDayId { get; set; }

    public int? CalendarYearFirstNonWorkingDayId { get; set; }

    public int? WeekP444FirstAllDayId { get; set; }

    public int? WeekP444FirstWeekDayId { get; set; }

    public int? WeekP444FirstWorkingDayId { get; set; }

    public int? WeekP444FirstHoliDayId { get; set; }

    public int? WeekP444FirstWeekendDayId { get; set; }

    public int? WeekP444FirstNonWorkingDayId { get; set; }

    public int? WeekP445FirstAllDayId { get; set; }

    public int? WeekP445FirstWeekDayId { get; set; }

    public int? WeekP445FirstWorkingDayId { get; set; }

    public int? WeekP445FirstHoliDayId { get; set; }

    public int? WeekP445FirstWeekendDayId { get; set; }

    public int? WeekP445FirstNonWorkingDayId { get; set; }

    public int? WeekQuarterFirstAllDayId { get; set; }

    public int? WeekQuarterFirstWeekDayId { get; set; }

    public int? WeekQuarterFirstWorkingDayId { get; set; }

    public int? WeekQuarterFirstHoliDayId { get; set; }

    public int? WeekQuarterFirstWeekendDayId { get; set; }

    public int? WeekQuarterFirstNonWorkingDayId { get; set; }

    public int? WeekYearFirstAllDayId { get; set; }

    public int? WeekYearFirstWeekDayId { get; set; }

    public int? WeekYearFirstWorkingDayId { get; set; }

    public int? WeekYearFirstHoliDayId { get; set; }

    public int? WeekYearFirstWeekendDayId { get; set; }

    public int? WeekYearFirstNonWorkingDayId { get; set; }

    public int? WeekLastAllDayId { get; set; }

    public int? WeekLastWeekDayId { get; set; }

    public int? WeekLastWorkingDayId { get; set; }

    public int? WeekLastHoliDayId { get; set; }

    public int? WeekLastWeekendDayId { get; set; }

    public int? WeekLastNonWorkingDayId { get; set; }

    public int? CalendarMonthLastAllDayId { get; set; }

    public int? CalendarMonthLastWeekDayId { get; set; }

    public int? CalendarMonthLastWorkingDayId { get; set; }

    public int? CalendarMonthLastHoliDayId { get; set; }

    public int? CalendarMonthLastWeekendDayId { get; set; }

    public int? CalendarMonthLastNonWorkingDayId { get; set; }

    public int? CalendarQuarterLastAllDayId { get; set; }

    public int? CalendarQuarterLastWeekDayId { get; set; }

    public int? CalendarQuarterLastWorkingDayId { get; set; }

    public int? CalendarQuarterLastHoliDayId { get; set; }

    public int? CalendarQuarterLastWeekendDayId { get; set; }

    public int? CalendarQuarterLastNonWorkingDayId { get; set; }

    public int? CalendarYearLastAllDayId { get; set; }

    public int? CalendarYearLastWeekDayId { get; set; }

    public int? CalendarYearLastWorkingDayId { get; set; }

    public int? CalendarYearLastHoliDayId { get; set; }

    public int? CalendarYearLastWeekendDayId { get; set; }

    public int? CalendarYearLastNonWorkingDayId { get; set; }

    public int? WeekP444LastAllDayId { get; set; }

    public int? WeekP444LastWeekDayId { get; set; }

    public int? WeekP444LastWorkingDayId { get; set; }

    public int? WeekP444LastHoliDayId { get; set; }

    public int? WeekP444LastWeekendDayId { get; set; }

    public int? WeekP444LastNonWorkingDayId { get; set; }

    public int? WeekP445LastAllDayId { get; set; }

    public int? WeekP445LastWeekDayId { get; set; }

    public int? WeekP445LastWorkingDayId { get; set; }

    public int? WeekP445LastHoliDayId { get; set; }

    public int? WeekP445LastWeekendDayId { get; set; }

    public int? WeekP445LastNonWorkingDayId { get; set; }

    public int? WeekQuarterLastAllDayId { get; set; }

    public int? WeekQuarterLastWeekDayId { get; set; }

    public int? WeekQuarterLastWorkingDayId { get; set; }

    public int? WeekQuarterLastHoliDayId { get; set; }

    public int? WeekQuarterLastWeekendDayId { get; set; }

    public int? WeekQuarterLastNonWorkingDayId { get; set; }

    public int? WeekYearLastAllDayId { get; set; }

    public int? WeekYearLastWeekDayId { get; set; }

    public int? WeekYearLastWorkingDayId { get; set; }

    public int? WeekYearLastHoliDayId { get; set; }

    public int? WeekYearLastWeekendDayId { get; set; }

    public int? WeekYearLastNonWorkingDayId { get; set; }

    public int? WeekAllNrOfDays { get; set; }

    public int? WeekWeekNrOfDays { get; set; }

    public int? WeekWorkingNrOfDays { get; set; }

    public int? WeekHoliNrOfDays { get; set; }

    public int? WeekWeekendNrOfDays { get; set; }

    public int? WeekNonWorkingNrOfDays { get; set; }

    public int? CalendarMonthAllNrOfDays { get; set; }

    public int? CalendarMonthWeekNrOfDays { get; set; }

    public int? CalendarMonthWorkingNrOfDays { get; set; }

    public int? CalendarMonthHoliNrOfDays { get; set; }

    public int? CalendarMonthWeekendNrOfDays { get; set; }

    public int? CalendarMonthNonWorkingNrOfDays { get; set; }

    public int? CalendarQuarterAllNrOfDays { get; set; }

    public int? CalendarQuarterWeekNrOfDays { get; set; }

    public int? CalendarQuarterWorkingNrOfDays { get; set; }

    public int? CalendarQuarterHoliNrOfDays { get; set; }

    public int? CalendarQuarterWeekendNrOfDays { get; set; }

    public int? CalendarQuarterNonWorkingNrOfDays { get; set; }

    public int? CalendarYearAllNrOfDays { get; set; }

    public int? CalendarYearWeekNrOfDays { get; set; }

    public int? CalendarYearWorkingNrOfDays { get; set; }

    public int? CalendarYearHoliNrOfDays { get; set; }

    public int? CalendarYearWeekendNrOfDays { get; set; }

    public int? CalendarYearNonWorkingNrOfDays { get; set; }

    public int? WeekP444AllNrOfDays { get; set; }

    public int? WeekP444WeekNrOfDays { get; set; }

    public int? WeekP444WorkingNrOfDays { get; set; }

    public int? WeekP444HoliNrOfDays { get; set; }

    public int? WeekP444WeekendNrOfDays { get; set; }

    public int? WeekP444NonWorkingNrOfDays { get; set; }

    public int? WeekP445AllNrOfDays { get; set; }

    public int? WeekP445WeekNrOfDays { get; set; }

    public int? WeekP445WorkingNrOfDays { get; set; }

    public int? WeekP445HoliNrOfDays { get; set; }

    public int? WeekP445WeekendNrOfDays { get; set; }

    public int? WeekP445NonWorkingNrOfDays { get; set; }

    public int? WeekQuarterAllNrOfDays { get; set; }

    public int? WeekQuarterWeekNrOfDays { get; set; }

    public int? WeekQuarterWorkingNrOfDays { get; set; }

    public int? WeekQuarterHoliNrOfDays { get; set; }

    public int? WeekQuarterWeekendNrOfDays { get; set; }

    public int? WeekQuarterNonWorkingNrOfDays { get; set; }

    public int? WeekYearAllNrOfDays { get; set; }

    public int? WeekYearWeekNrOfDays { get; set; }

    public int? WeekYearWorkingNrOfDays { get; set; }

    public int? WeekYearHoliNrOfDays { get; set; }

    public int? WeekYearWeekendNrOfDays { get; set; }

    public int? WeekYearNonWorkingNrOfDays { get; set; }
}
