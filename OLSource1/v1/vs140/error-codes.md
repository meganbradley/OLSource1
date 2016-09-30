---
title: "Error Codes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "error codes, source control plug-ins"
  - "source control plug-ins, error codes"
  - "errors [Visual Studio SDK]"
ms.assetid: d9cbd1c4-719b-467a-8100-333c1e146d3b
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Error Codes
When a Source Control Plug-in API function returns an error, it is expected to be one of the following error codes. All errors are negative, warnings or informational error codes are positive, and success is 0.  
  
|Error Code|Value|Description|  
|----------------|-----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|7|Plug-in supports adding files from source control in two steps. For more information, see [SccSetOption](../vs140/sccsetoption-function.md).|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|6|The local file is different from the file in the source control database (for example, [SccDiff](../vs140/sccdiff-function.md) may return this value).|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|5|Local file was changed during the source control operation; the IDE should reload the file if possible.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|4|The file is not affected.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|3|The Project was created during the source control operation (for example, during a call to [SccOpenProject](../vs140/sccopenproject-function.md) when <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> flag is specified).|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|2|Operation was cancelled.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|1|Plug-in supports advanced options for the specified command. For more information, see [SccGetCommandOptions](../vs140/sccgetcommandoptions-function.md).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|0|Success.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|-1|Error: initialization failed.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|-2|Error: project is unknown.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|-3|Error: project could not be created.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|-4|Error: the file is not checked out.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|-5|Error: the file is already checked out.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|-6|Error: the file is locked.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|-7|Error: the file is exclusively checked out.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|-8|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|-9|Error: there was a conflict during check in.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|-10|Error: the file already exists.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|-11|Error: the file is not under source control.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|-12|Error: the file is checked out.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|-13|Error: there is no specified version.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|-14|Error: the operation is not supported.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|-15|Nonspecific error.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|-16|Error, the operation was not performed.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|-17|Error: the type of the file, for example, binary, is not supported by the source code control system.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|-18|File has been auto-merged but has not been checked because it is pending user verification.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|-19|File has been auto-merged but has not been checked in due to a merge conflict that must be manually resolved.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|-20|Error due to a shell failure.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|-21|Error: the user is invalid.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|-22|Error: the project is already open.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|-23|Project syntax error.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|-24|Error: the file path is invalid.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|-25|Error: the project is not open.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|-26|Error: the user is not authorized to perform this operation.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|-27|File syntax error.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|-28|Error, the local file does not exist.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|-29|Error: there was a connection failure.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|-30|Unknown error.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|-31|Background get operation is currently in progress.|  
  
## Macros Provided for Quick Checking  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 All Source Control Plug-in API functions (except the [SccAdd Function](../vs140/sccadd-function.md), [SccCheckin Function](../vs140/scccheckin-function.md), and [SccDiff Function](../vs140/sccdiff-function.md)) are expected to succeed when the local files that are passed as arguments do not exist in the working folder. For example, the IDE may issue a call to the [SccCheckout Function](../vs140/scccheckout-function.md) or [SccUncheckout Function](../vs140/sccuncheckout-function.md) on a file that does not exist in the working folder, but exists in the source control system. This call would succeed. Only when there is no file in the working folder or in the source control system is the function expected to fail.  
  
 Certain functions, such as <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, should specifically return <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> when the file in the working folder does not exist. Other functions are expected to succeed when the working file does not exist, if the functions operate on a valid file name in the source control system.  
  
 The source control plug-in should make no assumptions regarding privileges on a file in the working folder, even if the plug-in had marked the file read-only during some operation. A file in the working folder can be moved, deleted, and changed outside the plug-in's control.  
  
## See Also  
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)