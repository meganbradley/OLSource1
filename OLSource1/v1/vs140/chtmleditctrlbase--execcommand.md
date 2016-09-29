---
title: "CHtmlEditCtrlBase::ExecCommand"
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
  - "CHtmlEditCtrlBase<T>.ExecCommand"
  - "CHtmlEditCtrlBase::ExecCommand"
  - "ExecCommand"
  - "CHtmlEditCtrlBase<T>::ExecCommand"
  - "CHtmlEditCtrlBase.ExecCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExecCommand method"
ms.assetid: 47452b43-ae8f-4ad1-877b-92ff0f3de7af
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::ExecCommand
Executes a command.  
  
## Syntax  
  
```  
  
      HRESULT ExecCommand(  
   long cmdID,  
   long cmdExecOpt,  
   VARIANT* pInVar = NULL,  
   VARIANT* pOutVar = NULL   
) const;  
HRESULT ExecCommand(  
   const GUID* pGuid,  
   long cmdID,  
   long cmdExecOpt,  
   VARIANT* pInVar = NULL,  
   VARIANT* pOutVar = NULL   
) const;  
```  
  
#### Parameters  
 `cmdID`  
 The command ID to be executed. For a list, see [MSHTML Command Identifiers](https://msdn.microsoft.com/en-us/library/aa741315.aspx).  
  
 `cmdExecOpt`  
 Values taken from the [OLECMDEXECOPT](http://msdn.microsoft.com/library/windows/desktop/ms683930) enumeration, which describe how the object should execute the command.  
  
 *pInVar*  
 The input arguments.  
  
 *pOutVar*  
 The command output.  
  
 *pGuid*  
 The GUID of the command group.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method provides the functionality of [IOleCommandTarget::Exec](http://msdn.microsoft.com/library/windows/desktop/ms690300).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)