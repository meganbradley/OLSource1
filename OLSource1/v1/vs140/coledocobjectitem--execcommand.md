---
title: "COleDocObjectItem::ExecCommand"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ExecCommand"
  - "COleDocObjectItem::ExecCommand"
  - "COleDocObjectItem.ExecCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExecCommand method"
  - "commands, executing"
ms.assetid: 339fe40a-1511-4ba3-8d90-00c9c35536a8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocObjectItem::ExecCommand
Call this member function to execute the command specified by the user.  
  
## Syntax  
  
```  
  
      HRESULT ExecCommand(  
   DWORD nCmdID,  
   DWORD nCmdExecOpt = OLECMDEXECOPT_DONTPROMPTUSER,  
   const GUID* pguidCmdGroup = NULL   
);  
```  
  
#### Parameters  
 `nCmdID`  
 The identifier of the command to execute. Must be in the group identified by `pguidCmdGroup`.  
  
 `nCmdExecOpt`  
 Specifies command-execution options. By default, set to execute the command without prompting the user. See [OLECMDEXECOPT](http://msdn.microsoft.com/library/windows/desktop/ms683930) for a list of values.  
  
 `pguidCmdGroup`  
 Unique identifier of the command group. By default, **NULL**, which specifies the standard group. The command passed in `nCmdID` must belong to the group.  
  
## Return Value  
 Returns `S_OK` if successful; otherwise,returns one of the following error codes.  
  
|Value|Description|  
|-----------|-----------------|  
|**E_UNEXPECTED**|Unexpected error occurred.|  
|**E_FAIL**|Error occurred.|  
|**E_NOTIMPL**|Indicates MFC itself should attempt to translate and dispatch the command.|  
|**OLECMDERR_E_UNKNOWNGROUP**|`pguidCmdGroup` is non-**NULL** but does not specify a recognized command group.|  
|**OLECMDERR_E_NOTSUPPORTED**|`nCmdID` is not recognized as a valid command in the group pGroup.|  
|**OLECMDERR_DISABLED**|The command identified by `nCmdID` is disabled and cannot be executed.|  
|**OLECMDERR_NOHELP**|Caller asked for help on the command identified by `nCmdID` but no help is available.|  
|**OLECMDERR_CANCELLED**|User canceled the execution.|  
  
## Remarks  
 The `pguidCmdGroup` and the `nCmdID` parameters together uniquely identify the command to invoke. The `nCmdExecOpt` parameter specifies the exact action to take.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocObjectItem Class](../vs140/coledocobjectitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IOleCommandTarget::Exec](http://msdn.microsoft.com/library/windows/desktop/ms690300)