---
title: "CPaneDivider::m_pSliderRTC"
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
  - "CPaneDivider.m_pSliderRTC"
  - "CPaneDivider::m_pSliderRTC"
  - "m_pSliderRTC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pSliderRTC"
  - "CPaneDivider class, data members"
ms.assetid: b038b501-b9a0-4dd0-9ba8-3fd18298f7b7
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneDivider::m_pSliderRTC
Holds a pointer to runtime class information about a `CPaneDivider`-derived object.  
  
## Syntax  
  
```  
AFX_IMPORT_DATA static CRuntimeClass* m_pSliderRTC;  
```  
  
## Remarks  
 Set this member variable if you create a custom pane divider. This enables the framework to create your pane divider when the pane is drawn.  
  
## Example  
 The following example shows how to set the `m_pSliderRTC` member variable:  
  
```  
class CMySplitter : public CPaneDivider  
{  
...  
};  
  
CPaneDivider::m_pSliderRTC = RUNTIME_CLASS(CMySpliter);  
```  
  
## Requirements  
 **Header:** afxPaneDivider.h  
  
## See Also  
 [CPaneDivider Class](../vs140/cpanedivider-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)