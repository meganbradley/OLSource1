---
title: "COleBusyDialog::GetSelectionType"
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
  - "GetSelectionType"
  - "COleBusyDialog::GetSelectionType"
  - "COleBusyDialog.GetSelectionType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectionType method"
  - "COleBusyDialog class, operations"
  - "selection"
ms.assetid: 5a727ee8-a78b-41a5-a13d-1128831ce88f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleBusyDialog::GetSelectionType
Call this function to get the selection type chosen by the user in the Server Busy dialog box.  
  
## Syntax  
  
```  
  
UINT GetSelectionType( ) const;  
```  
  
## Return Value  
 Type of selection made.  
  
## Remarks  
 The return type values are specified by the **Selection** enumeration type declared in the `COleBusyDialog` class.  
  
 `enum Selection`  
  
 `{`  
  
 `switchTo,`  
  
 `retry,`  
  
 `callUnblocked`  
  
 `};`  
  
 Brief descriptions of these values follow:  
  
-   **COleBusyDialog::switchTo** Switch To button was pressed.  
  
-   **COleBusyDialog::retry** Retry button was pressed.  
  
-   **COleBusyDialog::callUnblocked** Call to activate the server is now unblocked.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleBusyDialog Class](../vs140/colebusydialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleBusyDialog::DoModal](../vs140/colebusydialog--domodal.md)