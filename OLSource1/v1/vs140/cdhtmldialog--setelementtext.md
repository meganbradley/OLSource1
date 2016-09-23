---
title: "CDHtmlDialog::SetElementText"
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
  - SetElementText
  - CDHtmlDialog::SetElementText
  - CDHtmlDialog.SetElementText
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetElementText method
ms.assetid: fa03828d-5981-4fe7-87b5-7930ecc59ce1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::SetElementText
Sets the **innerText** property of an HTML element.  
  
## Syntax  
  
```  
  
      void SetElementText(  
   LPCTSTR szElementId,  
   BSTR bstrText   
);  
void SetElementText(  
   IUnknown *punkElem,  
   BSTR bstrText   
);  
```  
  
#### Parameters  
 `szElementId`  
 The ID of an HTML element.  
  
 `bstrText`  
 The new value of the **innerText** property.  
  
 `punkElem`  
 The **IUnknown** pointer of an HTML element.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::SetElementHtml](../vs140/cdhtmldialog--setelementhtml.md)   
 [CDHtmlDialog::SetElementProperty](../vs140/cdhtmldialog--setelementproperty.md)