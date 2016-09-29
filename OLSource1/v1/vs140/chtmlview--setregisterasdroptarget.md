---
title: "CHtmlView::SetRegisterAsDropTarget"
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
  - "CHtmlView.SetRegisterAsDropTarget"
  - "SetRegisterAsDropTarget"
  - "CHtmlView::SetRegisterAsDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "SetRegisterAsDropTarget method"
  - "CHtmlView class, attributes"
ms.assetid: a3213ea1-add0-4cfb-9a3b-c9b726a382f6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetRegisterAsDropTarget
Call this member function to set a value indicating whether the WebBrowser control is registered as a drop target for navigation.  
  
## Syntax  
  
```  
  
      void SetRegisterAsDropTarget(  
   BOOL bNewValue   
);  
```  
  
#### Parameters  
 `bNewValue`  
 Determines if the WebBrowser control is registered as a drop target for navigation. If nonzero, the object is registered as a drop target; if zero, it is not a drop target.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetRegisterAsDropTarget](../vs140/chtmlview--getregisterasdroptarget.md)   
 [IWebBrowser2::put_RegisterAsDropTarget](https://msdn.microsoft.com/en-us/library/aa768266.aspx)