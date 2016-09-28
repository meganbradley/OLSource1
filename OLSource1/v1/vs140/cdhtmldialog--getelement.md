---
title: "CDHtmlDialog::GetElement"
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
  - "CDHtmlDialog.GetElement"
  - "CDHtmlDialog::GetElement"
  - "GetElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElement method"
ms.assetid: a724e3aa-2861-4605-95c8-ccbe2e2c2861
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetElement
Returns an interface on the HTML element specified by `szElementId`.  
  
## Syntax  
  
```  
  
      HRESULT GetElement(  
   LPCTSTR szElementId,  
   IDispatch **ppdisp,  
   BOOL *pbCollection = NULL   
);  
HRESULT GetElement(  
   LPCTSTR szElementId,  
   IHTMLElement **pphtmlElement   
);  
```  
  
#### Parameters  
 `szElementId`  
 The ID of an HTML element.  
  
 *ppdisp*  
 An `IDispatch` pointer to the requested element or collection of elements.  
  
 *pbCollection*  
 A **BOOL** indicating whether the object represented by *ppdisp* is a single element or a collection of elements.  
  
 *pphtmlElement*  
 An **IHTMLElement** pointer to the requested element.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 Use the first overload if you need to handle conditions in which there may be more than one element with the specified ID. You can use the last parameter to find out whether the returned interface pointer is to a collection or a single item. If the interface pointer is on a collection, you can query for the **IHTMLElementCollection** and use its **item** property to refer to the elements by ordinal position.  
  
 The second overload will fail if there is more than one element with the same ID in the page.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::GetElementInterface](../vs140/cdhtmldialog--getelementinterface.md)   
 [CDHtmlDialog::GetControlDispatch](../vs140/cdhtmldialog--getcontroldispatch.md)