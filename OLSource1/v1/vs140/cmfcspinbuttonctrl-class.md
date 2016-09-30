---
title: "CMFCSpinButtonCtrl Class"
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
  - "CMFCSpinButtonCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCSpinButtonCtrl class"
ms.assetid: 8773f259-4d3f-4bca-a71c-09e0c71bc843
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCSpinButtonCtrl Class
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class supports a visual manager that draws a spin button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCSpinButtonCtrl::OnDraw](#cmfcspinbuttonctrl__ondraw)|Repaints the current spin button control.|  
  
## Remarks  
 To use a visual manager to draw a spin button control in your application, replace all instances of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class.  
  
## Example  
 The following example demonstrates how to create an object of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class and use its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method.  
  
 [!code[NVC_MFC_RibbonApp#25](../vs140/codesnippet/CPP/cmfcspinbuttonctrl-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CSpinButtonCtrl](../vs140/cspinbuttonctrl-class.md)  
  
 [CMFCSpinButtonCtrl](../vs140/cmfcspinbuttonctrl-class.md)  
  
## Requirements  
 **Header:** afxspinbuttonctrl.h  
  
##  \<a name="cmfcspinbuttonctrl__ondraw">\</a>  CMFCSpinButtonCtrl::OnDraw  
 Repaints the current spin button control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
 The framework calls the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method to handle the [WM_PAINT](../vs140/cwnd-class.md#cwnd__onpaint) message, and that method in turn calls this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method. Override this method to customize the way the framework draws the spin button control.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)