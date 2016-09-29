---
title: "CPropertyPage::OnApply"
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
  - "CPropertyPage::OnApply"
  - "CPropertyPage.OnApply"
  - "OnApply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property page overridables"
  - "CPropertyPage class, overridables"
  - "OnApply method"
ms.assetid: b60f6259-0927-46d1-861b-9e0f8557ff38
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::OnApply
This member function is called by the framework when the user chooses the OK or the Apply Now button.  
  
## Syntax  
  
```  
  
virtual BOOL OnApply( );  
  
```  
  
## Return Value  
 Nonzero if the changes are accepted; otherwise 0.  
  
## Remarks  
 When the framework calls this function, changes made on all property pages in the property sheet are accepted, the property sheet retains focus, and `OnApply` returns **TRUE** (the value 1). Before `OnApply` can be called by the framework, you must have called [SetModified](../vs140/cpropertypage--setmodified.md) and set its parameter to **TRUE**. This will activate the Apply Now button as soon as the user makes a change on the property page.  
  
 Override this member function to specify what action your program takes when the user clicks the Apply Now button. When overriding, the function should return **TRUE** to accept changes and **FALSE** to prevent changes from taking effect.  
  
 The default implementation of `OnApply` calls `OnOK`.  
  
 For more information about notification messages sent when the user presses the Apply Now or OK button in a property sheet, see [PSN_APPLY](http://msdn.microsoft.com/library/windows/desktop/bb774552) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CPropertyPage::OnOK](../vs140/cpropertypage--onok.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::SetModified](../vs140/cpropertypage--setmodified.md)   
 [CPropertyPage::OnOK](../vs140/cpropertypage--onok.md)