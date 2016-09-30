---
title: "DDX_Check"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DDX_Check"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_Check function"
ms.assetid: 4032d0c0-0bad-4af1-94d8-3065fc7135cd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_Check
The `DDX_Check` function manages the transfer of `int` data between a check box control in a dialog box, form view, or control view object and a `int` data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_Check(  
   CDataExchange* pDX,  
   int nIDC,  
   int& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The resource ID of the check box control associated with the control property.  
  
 *value*  
 A reference to a member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
 When `DDX_Check` is called, *value* is set to the current state of the check box control. For a list of the possible state values, see [BM_GETCHECK](http://msdn.microsoft.com/library/windows/desktop/bb775986) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_Check](../vs140/ddp_check.md)