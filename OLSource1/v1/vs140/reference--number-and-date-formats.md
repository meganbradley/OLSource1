---
title: "Reference: Number and Date Formats"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: aa96f060-b7ec-459f-95a6-ba7930d37345
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference: Number and Date Formats
You can modify the display format for numbers and dates in [!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] by setting the `Format Pattern` property. The following sections show the notation and rules for that property in addition to examples of format strings that are commonly used.  
  
> [!NOTE]
>  The examples assume that the application’s `Culture` property is set to **English (United States)**. If you change the `Culture` property in Visual Studio LightSwitch, culture-specific formatting will be applied only if the culture setting of the local machine matches.  
  
1.  [Numeric Formats](../vs140/reference--number-and-date-formats.md#NUMERIC)  
  
2.  [Standard Numeric Format Strings](../vs140/reference--number-and-date-formats.md#STANDARD)  
  
3.  [Custom Numeric Format Strings](../vs140/reference--number-and-date-formats.md#CUSTOM)  
  
4.  [Date and Time Formats](../vs140/reference--number-and-date-formats.md#DATET)  
  
5.  [Standard Date and Time Format Strings](../vs140/reference--number-and-date-formats.md#SDATE)  
  
6.  [Custom Date and Time Format Strings](../vs140/reference--number-and-date-formats.md#CDATE)  
  
7.  [Formatting Guids](../vs140/reference--number-and-date-formats.md#GUID)  
  
##  <a name="NUMERIC"></a> Numeric Formats  
 You can use numeric format strings to format the `Decimal`, `Double`, `Integer`, `Long Integer`, and `Short Integer` data types. A standard numeric format string takes the form `Axx`, where `A` is an alphabetic character that's called the format specifier, and `xx` is an optional integer that's called the precision specifier. The precision specifier ranges from 0 to 99 and affects the number of digits in the result.  
  
> [!NOTE]
>  For the `Decimal` data type, the precision specifier can't be larger than the Scale property value that's specified for the field. For the `Integer`, `Long Integer`, and `Short Integer` types, no precision specifier should be used.  
  
 You can also create a custom numeric format string, which consists of one or more custom numeric specifiers, to define how to format numeric data. Any numeric format string that contains more than one alphabetic character, including white space, is interpreted as a custom numeric format string.  
  
###  <a name="STANDARD"></a> Standard Numeric Format Strings  
 The following table lists the standard numeric format specifiers and displays sample output that each format string produces. For more information, see [Standard Numeric Format Strings](assetId:///580e57eb-ac47-4ffd-bccd-3a1637c2f467).  
  
|Format specifier|Name|Raw Value, Data Type|Format String|Displayed Result|  
|----------------------|----------|--------------------------|-------------------|----------------------|  
|"C" or "c"|Currency|123.456, `Double`<br /><br /> 123.456, `Double`<br /><br /> 123.456, `Double`<br /><br /> 123, `Integer`|C<br /><br /> C2<br /><br /> C3<br /><br /> C|$123.46<br /><br /> $123.46<br /><br /> $123.456<br /><br /> $123.00|  
|"D" or "d"|Decimal|1234, `Integer`<br /><br /> 1234, `Short Integer`<br /><br /> -1234, `Long Integer`|D<br /><br /> D6<br /><br /> D6|1234<br /><br /> 001234<br /><br /> -001234|  
|"E" or "e"|Exponential (scientific)|1052.0329112756, `Double`<br /><br /> -1052.0329112756, `Double`|E<br /><br /> E2|1.052033E+003<br /><br /> -1.05e+003|  
|"F" or "f"|Fixed-point|1234.567, `Double`<br /><br /> 1234, `Decimal`<br /><br /> -1234.56, `Double`|F<br /><br /> F1<br /><br /> F4|1234.57<br /><br /> 1234.0<br /><br /> -1234.5600|  
|"G" or "g"|General|-123.456, `Double`<br /><br /> 123.4546, `Double`<br /><br /> -1.234567890e-25, `Double`|G<br /><br /> G4<br /><br /> G|-123.456<br /><br /> 123.5<br /><br /> --1.23456789E-25|  
|"N" or "n"|Number|1234.567, `Double`<br /><br /> 1234, `Integer`<br /><br /> -1234.56, `Double`|N<br /><br /> N<br /><br /> N|1,234.57<br /><br /> 1,234.0<br /><br /> -1,234.560|  
|"P" or "p"|Percent|1, `Double`<br /><br /> -0.39678, `Double`|P<br /><br /> P1|100.00 %<br /><br /> -39.7 %|  
|"R" or "r"|Round-trip|123456789.12345678, `Double`<br /><br /> -1234567890.12345678, `Double`|R<br /><br /> R|123456789.12345678<br /><br /> -1234567890.1234567|  
|"X" or "x"|Hexadecimal|255, `Integer`<br /><br /> -1, `Integer`<br /><br /> 255, `Integer`<br /><br /> -1, `Integer`|X<br /><br /> X<br /><br /> X4<br /><br /> X4|FF<br /><br /> ff<br /><br /> 00ff<br /><br /> -00FF|  
  
###  <a name="CUSTOM"></a> Custom Numeric Format Strings  
 The following table describes the custom numeric format specifiers and displays sample output that each format string produces. For more information, see [Custom Numeric Format Strings](assetId:///6f74fd32-6c6b-48ed-8241-3c2b86dea5f4).  
  
|Format specifier|Name|Raw Value, Data Type|Format String|Displayed Result|  
|----------------------|----------|--------------------------|-------------------|----------------------|  
|"0"|Zero placeholder|1234.5678, `Double`<br /><br /> 0.45678, `Double`|00000<br /><br /> 0.00|01235<br /><br /> 0.46|  
|"#"|Digit placeholder|1234.5678, `Double`<br /><br /> 0.45678, `Double`|#####<br /><br /> #.##|1235<br /><br /> .46|  
|"."|Decimal point|0.45678, `Double`|0.00|0.46|  
|","|Group separator and number scaling|2147483647, `Integer`<br /><br /> 2147483647, `Integer`|##,#<br /><br /> #,#,,|2,147,483,647<br /><br /> 2,147|  
|"%"|Percentage placeholder|0.3697, `Double`<br /><br /> 0.3697, `Double`|%#0.00<br /><br /> ##.0 %|%36.97<br /><br /> 37.0 %|  
|"‰"|Per mille placeholder|0.03697, `Double`|#0.00‰|36.97‰|  
|"E0"<br /><br /> "E+0"<br /><br /> "E-0"<br /><br /> "e0"<br /><br /> "e+0"<br /><br /> "e-0"|Exponential notation|987654, `Double`<br /><br /> 1503.92311, `Double`<br /><br /> 1.8901385E-16 ("0.0e+00"), `Double`|#0.0e0<br /><br /> 0.0##e+00<br /><br /> 0.0e+00|98.8e4<br /><br /> 1.504e+03<br /><br /> 1.9e-16|  
|\|Escape character|987654, `Integer`|\\###00\\#|#987654#|  
|'*string*'<br /><br /> "*string*"|Literal string delimiter|68, `Integer`<br /><br /> 68, `Integer`|# ' degrees'<br /><br /> #” degrees”|68  degrees<br /><br /> 68 degrees|  
|;|Section separator|12.345, `Double`<br /><br /> 0, `Double`<br /><br /> -12.345, `Double`<br /><br /> 12.345, `Double`<br /><br /> 0, `Double`<br /><br /> -12.345, `Double`|#0.0#;(#0.0#);-\0-<br /><br /> #0.0#;(#0.0#);-\0-<br /><br /> #0.0#;(#0.0#);-\0-<br /><br /> #0.0#;(#0.0#)<br /><br /> #0.0#;(#0.0#)<br /><br /> #0.0#;(#0.0#)|12.35<br /><br /> -0-<br /><br /> (12.35)<br /><br /> 12.35<br /><br /> 0.0<br /><br /> (12.35)|  
|Other|All other characters|68, `Integer`|# °|68 °|  
  
###  <a name="DATET"></a> Date and Time Formats  
 You can use date and time format strings format the `Date` and `Date Time` data types. A standard date and time format string uses a single format specifier to define the text representation of a date and time value. Any date and time format string that contains more than one character, including white space, is interpreted as a custom date and time format string.  
  
###  <a name="SDATE"></a> Standard Date and Time Format Strings  
 The following table describes the standard date and time format specifiers. For more information, see [Standard Date and Time Format Strings](assetId:///bb79761a-ca08-44ee-b142-b06b3e2fc22b).  
  
|Format specifier|Description|Raw Value (`Date Time`)|Format String|Displayed Result|  
|----------------------|-----------------|-------------------------------|-------------------|----------------------|  
|"d"|Short date pattern.|6/15/2009 1:45:30 PM|d|6/15/2009|  
|"D"|Long date pattern.|6/15/2009 1:45:30 PM|D|Monday, June 15, 2009|  
|"f"|Full date/time pattern (short time).|6/15/2009 1:45:30 PM|f|Monday, June 15, 2009 1:45 PM|  
|"F"|Full date/time pattern (long time).|6/15/2009 1:45:30 PM|F|Monday, June 15, 2009 1:45:30 PM|  
|"g"|General date/time pattern (short time).|6/15/2009 1:45:30 PM|g|6/15/2009 1:45 PM|  
|"G"|General date/time pattern (long time).|6/15/2009 1:45:30 PM|G|6/15/2009 1:45:30 PM|  
|"M", "m"|Month/day pattern.|6/15/2009 1:45:30 PM|M|June 15|  
|"O", "o"|Round-trip date/time pattern.|6/15/2009 1:45:30 PM|O|2009-06-15T13:45:30.0900000|  
|"R", "r"|RFC1123 pattern.|6/15/2009 1:45:30 PM|R|Mon, 15 Jun 2009 20:45:30 GMT|  
|"s"|Sortable date/time pattern.|6/15/2009 1:45:30 PM|s|62009-06-15T13:45:30|  
|"t"|Short time pattern.|6/15/2009 1:45:30 PM|t|1:45 PM|  
|"T"|Long time pattern.|6/15/2009 1:45:30 PM|T|1:45:30 PM|  
|"u"|Universal sortable date/time pattern.|6/15/2009 1:45:30 PM|u|6/15/2009 1:45:30 PM -> 2009-06-15 20:45:30Z|  
U"|Universal full date/time pattern.|6/15/2009 1:45:30 PM|U|Monday, June 15, 2009 8:45:30 PM|  
|"Y", "y"|Year/month pattern.|6/15/2009 1:45:30 PM|Y|June, 2009|  
  
###  <a name="CDATE"></a> Custom Date and Time Format Strings  
 The following table describes the custom date and time format specifiers. For more information, see [Custom Date and Time Format Strings](assetId:///98b374e3-0cc2-4c78-ab44-efb671d71984).  
  
|Format specifier|Description|Raw Value (`Date Time`)|Format String|Displayed Result|  
|----------------------|-----------------|-------------------------------|-------------------|----------------------|  
|"d"|The day of the month, from 1 through 31.|6/1/2009 1:45:30 PM<br /><br /> 6/15/2009 1:45:30 PM|d<br /><br /> d|1<br /><br /> 15|  
|"dd"|The day of the month, from 01 through 31.|6/1/2009 1:45:30 PM<br /><br /> 6/15/2009 1:45:30 PM|dd<br /><br /> dd|01<br /><br /> 15|  
|"ddd"|The abbreviated name of the day of the week.|6/15/2009 1:45:30 PM|ddd|Mon|  
|"dddd"|The full name of the day of the week.|6/15/2009 1:45:30 PM|dddd|Monday|  
|"f"|The tenths of a second in a date and time value.|6/15/2009 13:45:30.617<br /><br /> 6/15/2009 13:45:30.050|f<br /><br /> f|6<br /><br /> 0|  
|"ff"|The hundredths of a second in a date and time value.|6/15/2009 13:45:30.617<br /><br /> 6/15/2009 13:45:30.005|ff<br /><br /> ff|61<br /><br /> 00|  
|"fff"|The milliseconds in a date and time value.|6/15/2009 13:45:30.617<br /><br /> 6/15/2009 13:45:30.0005|fff<br /><br /> fff|617<br /><br /> 000|  
|"ffff"|The ten thousandths of a second in a date and time value.|6/15/2009 13:45:30.6175<br /><br /> 6/15/2009 13:45:30.00005|ffff<br /><br /> ffff|6175<br /><br /> 0000|  
|"fffff"|The hundred thousandths of a second in a date and time value.|6/15/2009 13:45:30.61754<br /><br /> 6/15/2009 13:45:30.000005|fffff<br /><br /> fffff|61754<br /><br /> 00000|  
|"ffffff"|The millionths of a second in a date and time value.|6/15/2009 13:45:30.617542<br /><br /> 6/15/2009 13:45:30.0000005|ffffff<br /><br /> ffffff|617542<br /><br /> 000000|  
|"fffffff"|The ten millionths of a second in a date and time value.|6/15/2009 13:45:30.6175425<br /><br /> 6/15/2009 13:45:30.0001150|fffffff<br /><br /> fffffff|6175425<br /><br /> 0001150|  
|"F"|If non-zero, the tenths of a second in a date and time value.|6/15/2009 13:45:30.617<br /><br /> 6/15/2009 13:45:30.050|F<br /><br /> F|6<br /><br /> (no output)|  
|"FF"|If non-zero, the hundredths of a second in a date and time value.|6/15/2009 13:45:30.617<br /><br /> 6/15/2009 13:45:30.005|FF<br /><br /> FF|61<br /><br /> (no output)|  
FFF"|If non-zero, the milliseconds in a date and time value.|6/15/2009 13:45:30.617<br /><br /> 6/15/2009 13:45:30.0005|FFF<br /><br /> FFF|617<br /><br /> (no output)|  
|"FFFF"|If non-zero, the ten thousandths of a second in a date and time value.|6/1/2009 13:45:30.5275<br /><br /> 6/15/2009 13:45:30.00005|FFFF<br /><br /> FFFF|5275<br /><br /> (no output)|  
|"FFFFF"|If non-zero, the hundred thousandths of a second in a date and time value.|6/15/2009 13:45:30.61754<br /><br /> 6/15/2009 13:45:30.000005|FFFFF<br /><br /> FFFFF|61754<br /><br /> (no output)|  
|"FFFFFF"|If non-zero, the millionths of a second in a date and time value.|6/15/2009 13:45:30.617542<br /><br /> 6/15/2009 13:45:30.0000005|FFFFFF<br /><br /> FFFFFF|617542<br /><br /> (no output)|  
|"FFFFFFF"|If non-zero, the ten millionths of a second in a date and time value.|6/15/2009 13:45:30.6175425<br /><br /> 6/15/2009 13:45:30.0001150|FFFFFFF<br /><br /> FFFFFFF|6175425<br /><br /> 000115|  
|"g", "gg"|The period or era.|6/15/2009 1:45:30 PM|g|A.D.|  
|"h"|The hour, using a 12-hour clock from 1 to 12.|6/15/2009 1:45:30 AM<br /><br /> 6/15/2009 1:45:30 PM|h<br /><br /> h|1<br /><br /> 1|  
|"hh"|The hour, using a 12-hour clock from 01 to 12.|6/15/2009 1:45:30 AM<br /><br /> 6/15/2009 1:45:30 PM|hh<br /><br /> hh|01<br /><br /> 01|  
|"H"|The hour, using a 24-hour clock from 0 to 23.|6/15/2009 1:45:30 AM<br /><br /> 6/15/2009 1:45:30 PM|H<br /><br /> H|1<br /><br /> 13|  
|"HH"|The hour, using a 24-hour clock from 00 to 23.|6/15/2009 1:45:30 AM<br /><br /> 6/15/2009 1:45:30 PM|HH<br /><br /> HH|01<br /><br /> 13|  
m"|The minute, from 0 through 59.|6/15/2009 1:09:30 AM<br /><br /> 6/15/2009 1:29:30 PM|m<br /><br /> m|9<br /><br /> 29|  
|"mm"|The minute, from 00 through 59.|6/15/2009 1:09:30 AM<br /><br /> 6/15/2009 1:29:30 PM|mm<br /><br /> mm|09<br /><br /> 29|  
|"M"|The month, from 1 through 12.|6/15/2009 1:45:30 PM|M|6|  
|"MM"|The month, from 01 through 12.|6/15/2009 1:45:30 PM|MM|06|  
|"MMM"|The abbreviated name of the month.|6/15/2009 1:45:30 PM|MMM|Jun|  
|"MMMM"|The full name of the month.|6/15/2009 1:45:30 PM|MMMM|June|  
|"s"|The second, from 0 through 59.|6/15/2009 1:45:09 PM|s|9|  
|"ss"|The second, from 00 through 59.|6/15/2009 1:45:09 PM|ss|09|  
|"t"|The first character of the AM/PM designator.|6/15/2009 1:45:30 PM|t|P|  
|"tt"|The AM/PM designator.|6/15/2009 1:45:30 PM|tt|PM|  
|"y"|The year, from 0 to 99.|6/15/2009 1:45:30 PM|y|9|  
|"yy"|The year, from 00 to 99.|6/15/2009 1:45:30 PM|yy|09|  
|"yyy"|The year, with a minimum of three digits.|1/1/0001 12:00:00 AM<br /><br /> 6/15/2009 1:45:30 PM|yyy<br /><br /> yyy|001<br /><br /> 2009|  
|"yyyy"|The year as a four-digit number.|6/15/2009 1:45:30 PM|yyyy|2009|  
|"yyyyy"|The year as a five-digit number.|6/15/2009 1:45:30 PM|yyyyy|02009|  
|"z"|Hours offset from UTC, with no leading zeros.|6/15/2009 1:45:30 PM -07:00|z|-7|  
|"zz"|Hours offset from UTC, with a leading zero for a single-digit value.|6/15/2009 1:45:30 PM -07:00|zz|-07|  
|"zzz"|Hours and minutes offset from UTC.|6/15/2009 1:45:30 PM -07:00|zzz|-07:00|  
:"|The time separator.|6/15/2009 1:45:30 PM|hh:mm|01:45|  
|"/"|The date separator.|6/15/2009 1:45:30 PM|MM/dd|6/15|  
|"*string*"<br /><br /> '*string*'|Literal string delimiter.|6/15/2009 1:45:30 PM<br /><br /> 6/15/2009 1:45:30 PM|"arr:" h:m t<br /><br /> 'arr:' h:m t|arr: 1:45 P<br /><br /> arr: 1:45 P|  
|%|Defines the following character as a custom format specifier.|6/15/2009 1:45:30 PM|%h|1|  
|\|The escape character.|6/15/2009 1:45:30 PM|h \h|1 h|  
|Any other character|The character is copied to the result string unchanged.|6/15/2009 1:45:30 AM|arr hh:mm t|arr 01:45 A|  
  
###  <a name="GUID"></a> Formatting Guids  
 The following table describes format specifiers for the Guid data type.  
  
|Format|Description|Raw Value (`Guid`)|Format String|Displayed Result|  
|------------|-----------------|--------------------------|-------------------|----------------------|  
|N|Displays 32 characters.|3261a3cfc18f4747b957e5264b6a430c|N|3261a3cfc18f4747b957e5264b6a430c|  
|D|Displays 32 characters separated by hyphens.|3261a3cfc18f4747b957e5264b6a430c|D|3261a3cf-c18f-4747-b957-e5264b6a430c|  
|B|Displays 32 characters separated by hyphens and enclosed in braces.|3261a3cfc18f4747b957e5264b6a430c|B|{3261a3cf-c18f-4747-b957-e5264b6a430c }|  
|P|Displays 32 characters separated by hyphens and enclosed in parentheses.|3261a3cfc18f4747b957e5264b6a430c|P|(3261a3cf-c18f-4747-b957-e5264b6a430c)|  
|X|Four hexadecimal values enclosed in braces, where the fourth value is a subset of eight hexadecimal values enclosed in another set of braces.|3261a3cfc18f4747b957e5264b6a430c|X|{0x3261a3cf,0xc18f,0x4747,{0xb0,0x57,0xe5,0x26,0x4b,0x6a,0x43,0x0c}}|  
  
## See Also  
 [How to: Format Numbers and Dates](../vs140/how-to--format-numbers-and-dates-in-a-lightswitch-application.md)   
 [Data: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)   
 [Formatting Types](assetId:///0d1364da-5b30-4d42-8e6b-03378343343f)