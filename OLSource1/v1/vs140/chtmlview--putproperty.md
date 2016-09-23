---
title: "CHtmlView::PutProperty"
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
  - CHtmlView::PutProperty
  - PutProperty
  - CHtmlView.PutProperty
dev_langs: 
  - C++
helpviewer_keywords: 
  - CHtmlView class, operations
  - PutProperty method
ms.assetid: 08696b27-bc6e-4bcf-8691-f744252284a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::PutProperty
Call this member function to set the property associated with a given object.  
  
## Syntax  
  
```  
  
      void PutProperty(  
   LPCTSTR lpszProperty,  
   const VARIANT& vtValue   
);  
void PutProperty(  
   LPCTSTR lpszPropertyName,  
   double dValue   
);  
void PutProperty(  
   LPCTSTR lpszPropertyName,  
   long lValue   
);  
void PutProperty(  
   LPCTSTR lpszPropertyName,  
   LPCTSTR lpszValue   
);  
void PutProperty(  
   LPCTSTR lpszPropertyName,  
   short nValue   
);  
```  
  
#### Parameters  
 `lpszProperty`  
 A string containing the property to set.  
  
 *vtValue*  
 The new value of the property indicated by `lpszProperty`.  
  
 *lpszPropertyName*  
 A pointer to a string containing the name of the property to set.  
  
 *dValue*  
 The new value of the property.  
  
 `lValue`  
 The new value of the property.  
  
 `lpszValue`  
 A pointer to a string containing the new value of the property.  
  
 `nValue`  
 The new value of the property.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetProperty](../vs140/chtmlview--getproperty.md)   
 [IWebBrowser2::PutProperty](https://msdn.microsoft.com/en-us/library/aa752138.aspx)