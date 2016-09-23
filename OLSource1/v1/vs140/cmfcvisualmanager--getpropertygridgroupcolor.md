---
title: "CMFCVisualManager::GetPropertyGridGroupColor"
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
  - CMFCVisualManager::GetPropListGridGroupColor
  - GetPropListGridGroupColor
  - CMFCVisualManager.GetPropListGridGroupColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPropertyGridGroupColor method
ms.assetid: 77d10291-7c9c-4c56-a329-08653b203ccb
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::GetPropertyGridGroupColor
The framework calls this method to get the background color of a property list.  
  
## Syntax  
  
```  
virtual COLORREF GetPropertyGridGroupColor(  
   CMFCPropertyGridCtrl* pPropList   
);  
```  
  
#### Parameters  
 [in] `pPropList`  
 A pointer to the property list that the framework is drawing.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the background color of `pPropList`.  
  
## Remarks  
 Override this function to customize the background color of a property list in your application.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)