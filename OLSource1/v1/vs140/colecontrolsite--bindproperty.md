---
title: "COleControlSite::BindProperty"
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
  - "BindProperty"
  - "COleControlSite.BindProperty"
  - "COleControlSite::BindProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BindProperty method"
ms.assetid: 2f29a3fa-6dfb-4f37-b9ac-df61d4703a7d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::BindProperty
Binds the calling object's simple bound property, as marked in the type library, to the underlying cursor that is defined by the DataSource, UserName, Password, and SQL properties of the data-source control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwDispId*  
 Specifies the **DISPID** of a property on a data-bound control that is to be bound to a data-source control.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived object that hosts the data-source control to which the property will be bound.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object on which you call this function must be a data-bound control.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::BindDefaultProperty](../vs140/colecontrolsite--binddefaultproperty.md)