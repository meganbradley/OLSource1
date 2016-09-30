---
title: "Bitflags Used by Specific Commands"
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
  - "source control plug-ins, bitflags used by specific commands"
ms.assetid: 37969977-6f7d-45c9-ba03-1306ae71f5d1
caps.latest.revision: 28
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Bitflags Used by Specific Commands
The behavior of a number of functions in the Source Control Plug-in API can be modified by setting one or more bits in a single value. These values are known as bitflags. The various bitflags used by the Source Control Plug-in API are detailed here, grouped by the function that uses them.  
  
## Checked Out Flag  
 This flag can be set for either the [SccAdd Function](../vs140/sccadd-function.md) or [SccCheckin Function](../vs140/scccheckin-function.md).  
  
|Flag|Value|Description|  
|----------|-----------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|0x1000|Keep the file checked out.|  
  
## Add Flags  
 These flags are used by the [SccAdd Function](../vs140/sccadd-function.md).  
  
|Flag|Value|Description|  
|----------|-----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|0x00|The source control plug-in is expected to automatically detect whether the file is text or binary.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|0x01|File type is text.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|0x04|File type is binary. **Note:**  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> flags are mutually exclusive. Set exactly one or neither.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|0x02|Store latest version only (no deltas).|  
  
## Diff Flags  
 The [SccDiff Function](../vs140/sccdiff-function.md) uses these flags to define the scope of a diff operation. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> flags are mutually exclusive. If any one of them is specified, then no visual feedback is to be given. In a "quick diff" (QD), the plug-in does not determine how the file is different, only if it is different. If none of these flags is specified, a "visual diff" is done; detailed file differences are computed and displayed. If the requested QD is not supported, the plug-in moves to the next best one. For instance, if the IDE requests a checksum, and the plug-in does not support it, the plug-in does a full-contents check (still much faster than a visual display).  
  
|Flag|Value|Description|  
|----------|-----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|0x0002|Ignore case differences.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|0x0004|Ignore white-space differences. **Note:**  The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> flags are optional bitflags.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|0x0010|QD by comparing entire file contents.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|0x0020|QD by checksum.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|0x0040|QD by file date/time stamp.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|0x0070|This is a mask used to check all the QD bitflags. It should not be passed into a function; the three QD bitflags are mutually exclusive. QD always means no display of UI.|  
  
## PopulateList Flag  
 This flag is used by the [SccPopulateList Function](../vs140/sccpopulatelist-function.md) in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.  
  
|Flag|Value|Description|  
|----------|-----------|-----------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|0x00000001L|The IDE is passing directories, not files.|  
  
## PopulateDirList Flags  
 These flags are used by the [SccPopulateDirList Function](../vs140/sccpopulatedirlist-function.md) in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.  
  
|Option Value|Value|Description|  
|------------------|-----------|-----------------|  
|SCC_PDL_ONELEVEL|0x0000|Examine only one level of directories for directories (this is the default).|  
|SCC_PDL_RECURSIVE|0x0001|Recursively examine all directories under each given directory.|  
|SCC_PDL_INCLUDEFILES|0x0002|Include file names in the examination process.|  
  
## OpenProject Flags  
 These flags are used by the [SccOpenProject Function](../vs140/sccopenproject-function.md) in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter.  
  
|Option Value|Value|Description|  
|------------------|-----------|-----------------|  
|SCC_OP_CREATEIFNEW|0x00000001L|If project doesn't exist in source control, create it. If this flag is not set, prompt user for project to create (unless <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> flag is specified).|  
|SCC_OP_SILENTOPEN|0x00000002L|Do not prompt user to create a project; just return <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
## Get Flags  
 These flags are used by the [SccGet Function](../vs140/sccget-function.md) and the [SccCheckout Function](../vs140/scccheckout-function.md).  
  
|Flag|Value|Description|  
|----------|-----------|-----------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|0x00000001L|The IDE is passing directories, not files: Get all files in these directories.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|0x00000002L|The IDE is passing directories: Get these directories and all their subdirectories.|  
  
## nOption Values  
 These flags are used by the [SccSetOption Function](../vs140/sccsetoption-function.md) in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.  
  
|Flag|Value|Description|  
|----------|-----------|-----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|0x00000001L|Set status of the event queue.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|0x00000002L|Specify user data for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|0x00000003L|The IDE can handle cancel|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|0x00000004L|Set a callback for name changes.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|0x00000005L|Disable source control plug-in UI checkout and do not set working directory.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|0x00000006L|Add from the source control system to specify a working directory. Try to share into the associated project if it is a direct descendant.|  
  
## dwVal Bitflags  
 These flags are used by the [SccSetOption Function](../vs140/sccsetoption-function.md) in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter.  
  
|Flag|Value|Description|Used by <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value|  
|----------|-----------|-----------------|-----------------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|0x00L|Suspends event queue activity.|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|0x01L|Enables event queue logging.|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|0L|(Default) Has no cancel mode; plug-in must supply if desired.|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|1L|IDE handles cancel.|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|0L|(Default) OK to check out from plug-in UI; working directory is set.|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|1L|No plug-in UI checkout, no working directory.|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
  
## See Also  
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)