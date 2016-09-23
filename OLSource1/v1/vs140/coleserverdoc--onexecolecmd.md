---
title: "COleServerDoc::OnExecOleCmd"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleServerDoc.OnExecOleCmd
  - COleServerDoc::OnExecOleCmd
  - OnExecOleCmd
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerDoc class, operations
  - OnExecOleCmd method
ms.assetid: aa774ec7-752c-4b1f-b440-8e3e65e3fcb6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerDoc::OnExecOleCmd
The framework calls this function to execute a specified command or display help for the command.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnExecOleCmd(   
   const GUID* pguidCmdGroup,   
   DWORD nCmdID,   
   DWORD nCmdExecOpt,   
   VARIANTARG* pvarargIn,   
   VARIANTARG* pvarargOut   
);  
```  
  
#### Parameters  
 `pguidCmdGroup`  
 A pointer to a GUID that identifies a set of commands. Can be **NULL** to indicate the default command group.  
  
 `nCmdID`  
 The command to execute. Must be in the group identified by `pguidCmdGroup`.  
  
 *nCmdExecOut*  
 The way the object should execute the command, one or more of the following values from the **OLECMDEXECOPT** enumeration:  
  
 **OLECMDEXECOPT_DODEFAULT**  
  
 **OLECMDEXECOPT_PROMPTUSER**  
  
 **OLECMDEXECOPT_DONTPROMPTUSER**  
  
 **OLECMDEXECOPT_SHOWHELP**  
  
 `pvarargIn`  
 Pointer to a **VARIANTARG** containing input arguments for the command. Can be **NULL**.  
  
 `pvarargOut`  
 Pointer to a **VARIANTARG** to receive the output return values from the command. Can be **NULL**.  
  
## Return Value  
 Returns `S_OK` if successful; otherwise, one of the following error codes:  
  
|Value|Description|  
|-----------|-----------------|  
|**E_UNEXPECTED**|Unexpected error occurred|  
|**E_FAIL**|Error occurred|  
|**E_NOTIMPL**|Indicates MFC itself should attempt to translate and dispatch the command|  
|**OLECMDERR_E_UNKNOWNGROUP**|`pguidCmdGroup` is non-**NULL** but does not specify a recognized command group|  
|**OLECMDERR_E_NOTSUPPORTED**|`nCmdID` is not recognized as a valid command in the group `pguidCmdGroup`|  
|**OLECMDERR_DISABLED**|The command identified by `nCmdID` is disabled and cannot be executed|  
|**OLECMDERR_NOHELP**|Caller asked for help on the command identified by `nCmdID` but no help is available|  
|**OLECMDERR_CANCELED**|User canceled the execution|  
  
## Remarks  
 `COleCmdUI` can be used to enable, update, and set other properties of DocObject user interface commands. After the commands are initialized, you can execute them with `OnExecOleCmd`.  
  
 The framework calls the function before attempting to translate and dispatch an OLE document command. You don't need to override this function to handle standard OLE document commands, but you must supply an override to this function if you want to handle your own custom commands or handle commands that accept parameters or return results.  
  
 Most of the commands do not take arguments or return values. For a majority of commands the caller can pass **NULL**s for `pvarargIn` and `pvarargOut`. For commands that expect input values, the caller can declare and initialize a **VARIANTARG** variable and pass a pointer to the variable in `pvarargIn`. For commands that require a single value, the argument can be stored directly in the **VARIANTARG** and passed to the function. Multiple arguments must be packaged within the **VARIANTARG** using one of the supported types (such as `IDispatch` and **SAFEARRAY** ).  
  
 Similarly, if a command returns arguments the caller is expected to declare a **VARIANTARG**, initialize it to `VT_EMPTY`, and pass its address in `pvarargOut`. If a command returns a single value, the object can store that value directly in `pvarargOut`. Multiple output values must be packaged in some way appropriate for the **VARIANTARG**.  
  
 The base-class implementation of this function will walk the **OLE_COMMAND_MAP** structures associated with the command target and try to dispatch the command to an appropriate handler. The base-class implementation works only with commands that do not accept arguments or return values. If you need to handle commands that do accept arguments or return values, you must override this function and work with the `pvarargIn` and `pvarargOut` parameters yourself.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCmdUI Class](../vs140/colecmdui-class.md)