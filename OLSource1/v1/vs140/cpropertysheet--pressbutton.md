---
title: "CPropertySheet::PressButton"
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
  - "CPropertySheet::PressButton"
  - "CPropertySheet.PressButton"
  - "PSM_PRESSBUTTON"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, operations"
  - "buttons, property sheets"
  - "PSM_PRESSBUTTON"
  - "property sheet buttons"
  - "PressButton method"
  - "Pressbutton message"
  - "Press buttons in property sheets"
ms.assetid: 4c62da59-da6e-46af-9115-816e67ddd032
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::PressButton
Simulates the choice of the specified button in a property sheet.  
  
## Syntax  
  
```  
  
      void PressButton(  
   int nButton   
);  
```  
  
#### Parameters  
 `nButton`  
 nButton : Identifies the button to be pressed. This parameter can be one of the following values:  
  
-   **PSBTN_BACK** Chooses the Back button.  
  
-   **PSBTN_NEXT** Chooses the Next button.  
  
-   **PSBTN_FINISH** Chooses the Finish button.  
  
-   **PSBTN_OK** Chooses the OK button.  
  
-   **PSBTN_APPLYNOW** Chooses the Apply Now button.  
  
-   **PSBTN_CANCEL** Chooses the Cancel button.  
  
-   **PSBTN_HELP** Chooses the Help button.  
  
## Remarks  
 See [PSM_PRESSBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb774597) for more information about the Windows SDK Pressbutton message.  
  
 A call to `PressButton` will not send the [PSN_APPLY](http://msdn.microsoft.com/library/windows/desktop/bb774552) notification from a property page to the framework. To send this notification, call [CPropertyPage::OnOK](../vs140/cpropertypage--onok.md).  
  
## Example  
 [!code[NVC_MFCDocView#137](../vs140/codesnippet/CPP/cpropertysheet--pressbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)