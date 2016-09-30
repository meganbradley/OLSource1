---
title: "Capability Flags"
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
  - "source control plug-ins, capability flags"
ms.assetid: a3f6071c-eac8-4bcd-8ffd-8d0a2d24a252
caps.latest.revision: 28
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Capability Flags
The SCC_CAP_*xxx* flags are bit flags used to indicate the capabilities of a source control plug-in. The SCC_EXCAP_*xxx* flags are incremental flags that indicate extended capabilities and resolve to integer values.  
  
|Capability Code|Value|Description|  
|---------------------|-----------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|0x00000001L|Supports the [SccRemove Function](../vs140/sccremove-function.md) and command.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|0x00000002L|Supports the [SccRename Function](../vs140/sccrename-function.md) and command.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|0x00000004L|Supports the [SccDiff Function](../vs140/sccdiff-function.md) and command.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|0x00000008L|Supports the [SccHistory Function](../vs140/scchistory-function.md) and command.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|0x00000010L|Supports the [SccProperties Function](../vs140/sccproperties-function.md) and command.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|0x00000020L|Supports the [SccRunScc Function](../vs140/sccrunscc-function.md) and command.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|0x00000040L|Supports the [SccGetCommandOptions Function](../vs140/sccgetcommandoptions-function.md) and command.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|0x00000080L|Supports the [SccQueryInfo Function](../vs140/sccqueryinfo-function.md) and command.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|0x00000100L|Supports the [SccGetEvents Function](../vs140/sccgetevents-function.md) and command.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|0x00000200L|Supports the [SccGetProjPath Function](../vs140/sccgetprojpath-function.md) and command.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|0x00000400L|Supports the [SccAddFromScc Function](../vs140/sccaddfromscc-function.md) and command.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|0x00000800L|Supports a comment on checkout.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|0x00001000L|Supports a comment on checkin.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|0x00002000L|Supports a comment on Add.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|0x00004000L|Supports a comment on Remove.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|0x00008000L|Writes text to an IDE-provided output function.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|0x00200000L|Supports storing files without deltas.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|0x00400000L|Supports multiple file history.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|0x00800000L|Supports case-insensitive file comparison.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|0x01000000L|Supports file comparison that ignores white space.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|0x02000000L|Supports finding extra files.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|0x04000000L|Supports comments on create project.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|0x10000000L|Supports diff in all states if under control.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|0x20000000L|Plug-in does not support a UI for Get, but IDE may still call [SccGet Function](../vs140/sccget-function.md).|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|0x40000000L|Plug-in is reentrant and thread-safe. In version 1.0, no plug-ins were assumed to be reentrant and thread-safe. If a 1.1 plug-in sets this bit, the host is allowed to open multiple projects in parallel.|  
  
## Capability Bits added in Version 1.2  
  
|Capability Code|Value|Description|  
|---------------------|-----------|-----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|0x00010000L|Supports the [SccCreateSubProject Function](../vs140/scccreatesubproject-function.md).|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|0x00020000L|Supports the [SccGetParentProjectPath Function](../vs140/sccgetparentprojectpath-function.md).|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|0x00040000L|Supports the [SccBeginBatch Function](../vs140/sccbeginbatch-function.md) and [SccEndBatch Function](../vs140/sccendbatch-function.md).|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|0x00080000L|Supports the [SccDirQueryInfo Function](../vs140/sccdirqueryinfo-function.md).|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|0x00100000L|Supports the [SccDirDiff Function](../vs140/sccdirdiff-function.md).|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|0x08000000L|Supports multiple checkouts on a file and the [SccIsMultiCheckoutEnabled Function](../vs140/sccismulticheckoutenabled-function.md).|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|0x80000000L|Supports the MSSCCPRJ.SCC file (subject to user/administrator override) and the [SccWillCreateSccFile Function](../vs140/sccwillcreatesccfile-function.md).|  
  
## Capability Bits Added in Version 1.3  
 These flags are passed one at a time to the [SccGetExtendedCapabilities](../vs140/sccgetextendedcapabilities-function.md) function to determine whether the capability is supported.  
  
|Extended Capability Code|Value|Description|  
|------------------------------|-----------|-----------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|1|Supports the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> option for checkouts.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|2|Supports the [SccBackgroundGet Function](../vs140/sccbackgroundget-function.md).|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|3|Supports the [SccEnumChangedFiles Function](../vs140/sccenumchangedfiles-function.md).|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|4|Supports finding extra directories.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|5|Supports enumerating file changes.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|6|Supports the [SccAddFilesFromSCC Function](../vs140/sccaddfilesfromscc-function.md).|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|7|Supports the [SccGetUserOption Function](../vs140/sccgetuseroption-function.md).|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|8|Supports calling SccQueryInfo on multiple threads.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|9|Supports the SccRemoveDir function.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|10|Can delete checked-out files.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|11|Can rename checked-out files.|  
  
## See Also  
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)