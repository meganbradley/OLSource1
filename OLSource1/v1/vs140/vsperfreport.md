---
title: "VSPerfReport"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "command-line tools, VSPerfReporttool"
  - "performance tools, VSPerfReport tool"
  - "profiling tools,VSPerfReport"
  - "VSPerfReport tool"
  - "command line, tools"
  - "instrumentation, VSPerfReporttool"
ms.assetid: dbfd8d91-4430-4b82-81b9-97ac61412a6c
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSPerfReport
VSPerfReport command line tool is used to create reports using  [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Profiling Tools profiling data files. The default report format is a .csv file.  
  
 VSPerfReport uses the following syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> must be a valid .vsp or .vsps file.  
  
 The VSPerfReport command line tool is also used to compare .vsp or .vsps files. To generate a difference ("diff") report, use the following syntax:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be valid .vsp or .vsps files.  
  
## Symbol Files  
 To display symbol information such as function names and line numbers, VSPerfReport requires access to the symbol (.PDB) files of the profiled components and to Windows symbol files. For more information, see [How to: Specify Symbol File Locations from the Command Line](../vs140/how-to--specify-symbol-file-locations-from-the-command-line.md).  
  
## General Report Options  
 The following table describes the general report formatting options and the options that select the data to be reported.  
  
|Options|Description|  
|-------------|-----------------|  
|**U**|Report output and redirected console output are written as Unicode. Must be the first option specified.|  
|**Summary:**[*types*]|Creates one or more types of reports.\<br />\<br /> -   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> - all report types are generated.\<br />-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> - parent/child relationships between functions.\<br />-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> - functions called.\<br />-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> - hierarchy of functions called.\<br />-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> - all marks together with Windows performance counter values.\<br />-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> - instructions profiled.\<br />-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> - lifetime of allocated objects (available when allocation data has been collected.)\<br />-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> source code line profile data.\<br />-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> - report contains file header information.\<br />-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> all marks.\<br />-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> - modules profiled.\<br />-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> - processes profiled.\<br />-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> - threads profiled.\<br />-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> - allocated types.\<br />-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> - resource contentions.\<br />-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> - performance rule issues\<br />-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> - all Event Tracing for Windows (ETW) events collected in the profiling run. The .etl data file must be in its original location or in the directory containing the .vsp or .vsps file.|  
|**Xml**|Output report in XML format.|  
|**CallTrace**|Creates a list of function entry and exits, ETW events, and marks.|  
|**ClearPackedSymbols**|Removes previously embedded symbols from a profiler data file. Run this command before running PackSymbols a second time.|  
|**SymbolPath:** <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Specifies one or more search paths or symbol servers that contain symbols for the profiler data file.|  
|**DebugSymPath**|Lists the locations that are searched for symbols and whether they are found. This option is useful to resolve symbol resolution issues.|  
|**PackSymbols**|Saves symbols into the profiling data (.vsp) file so that symbol (.pdb) files are not required for analysis.|  
|**Output:** *path*&#124;*filename*|Specifies an alternate location for the generated report files. By default, reports are created in the current directory.|  
|**SummaryFile**|Analyze and save the analyzed information in a .vsps summary file.|  
|**PrintMarks**|Show the names and timestamps for all marks in the specified report file.|  
|**?**|Displays usage information.|  
|**NoLogo**|Hides version information when the report is running.|  
|**UserRulesDirectory**|Specifies directory containing user-defined performance rules [Not yet implemented].|  
  
## Filter Options  
 The following table describes the options to filter the available data.  
  
|Options|Description|  
|-------------|-----------------|  
|**JustMyCode**[**:**[<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>][,<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>]]|Only show user application function calls; hide system calls.\<br />\<br /> -   No parameters - hide all system functions.\<br />-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> - show one level of system functions that call application functions.\<br />-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> - show one level of system functions that are called by user application functions.|  
|**StartTime:**[*value*]|Only show data collected after value (in milliseconds.)|  
|**EndTime:**[*value*]|Only show data collected before value (in milliseconds.)|  
|**FilterFile:** <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Specifies the location of a filter file that was generated from the Visual Studio Performance Report window.|  
|**MsFilter:**[*starttime,duration*]|Only show data from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> until the length of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (in milliseconds.)|  
|**Process:**[*pid*]|Only show data from the specified process.|  
|**Thread:**[*threadid*]|Only show data from the specified thread.|  
|**Thread:**[*threadid,processid*]|Only show data from the specified thread associated with the specified process.|  
  
## Difference Report Options  
 The following table describes the options for comparing report files.  
  
|Options|Description|  
|-------------|-----------------|  
|**Diff**  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Compare two report files (.vsp or .vsps) files. Summary options will be ignored using the diff option.|  
|**Diff:**[*value*]|Below this threshold value the difference between two values will be disregarded. Also, new data with values under this threshold will not be shown.|  
|**DiffTable:**[*tablename*]|Use this specific table to compare files. The default is the functions table.|  
|**DiffColumn:**[*columnname*]|Use this specific column compare values. The default is the exclusive samples percent column.|  
|**QueryDiffTables**|List the valid tables and columns for the two report files provided.|  
  
## See Also  
 [Profiling Tools Report Views](../vs140/performance-report-views.md)