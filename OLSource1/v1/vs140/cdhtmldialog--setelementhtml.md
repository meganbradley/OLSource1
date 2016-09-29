---
title: "CDHtmlDialog::SetElementHtml"
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
  - "CDHtmlDialog.SetElementHtml"
  - "SetElementHtml"
  - "CDHtmlDialog::SetElementHtml"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetElementHtml method"
ms.assetid: cc787e5e-debc-4161-b5fa-272a66065aaf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::SetElementHtml
Sets the **innerHTML** property of an HTML element.  
  
## Syntax  
  
```  
  
      void SetElementHtml(  
   LPCTSTR szElementId,  
   BSTR bstrText   
);  
void SetElementHtml(  
   IUnknown *punkElem,  
   BSTR bstrText   
);  
```  
  
#### Parameters  
 `szElementId`  
 The ID of an HTML element.  
  
 `bstrText`  
 The new value of the **innerHTML** property.  
  
 `punkElem`  
 The **IUnknown** pointer of an HTML element.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::SetElementText](../vs140/cdhtmldialog--setelementtext.md)   
 [CDHtmlDialog::SetElementProperty](../vs140/cdhtmldialog--setelementproperty.md)