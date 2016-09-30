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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocObjectItem::ExecCommand
Call this member function to execute the command specified by the user.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The identifier of the command to execute. Must be in the group identified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies command-execution options. By default, set to execute the command without prompting the user. See [OLECMDEXECOPT](http://msdn.microsoft.com/library/windows/desktop/ms683930) for a list of values.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Unique identifier of the command group. By default, **NULL**, which specifies the standard group. The command passed in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must belong to the group.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if successful; otherwise,returns one of the following error codes.  
  
|Value|Description|  
|-----------|-----------------|  
|**E_UNEXPECTED**|Unexpected error occurred.|  
|**E_FAIL**|Error occurred.|  
|**E_NOTIMPL**|Indicates MFC itself should attempt to translate and dispatch the command.|  
|**OLECMDERR_E_UNKNOWNGROUP**|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is non-**NULL** but does not specify a recognized command group.|  
|**OLECMDERR_E_NOTSUPPORTED**|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not recognized as a valid command in the group pGroup.|  
|**OLECMDERR_DISABLED**|The command identified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is disabled and cannot be executed.|  
|**OLECMDERR_NOHELP**|Caller asked for help on the command identified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> but no help is available.|  
|**OLECMDERR_CANCELLED**|User canceled the execution.|  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters together uniquely identify the command to invoke. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter specifies the exact action to take.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocObjectItem Class](../vs140/coledocobjectitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IOleCommandTarget::Exec](http://msdn.microsoft.com/library/windows/desktop/ms690300)