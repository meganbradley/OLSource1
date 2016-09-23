---
title: "CDHtmlDialog::GetElementInterface"
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
  - GetElementInterface
  - CDHtmlDialog::GetElementInterface
  - CDHtmlDialog::GetElementInterface<Q>
  - CDHtmlDialog.GetElementInterface<Q>
  - CDHtmlDialog.GetElementInterface
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetElementInterface method
ms.assetid: 0459f728-1585-46c4-9e90-b32fc9c05004
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::GetElementInterface
Retrieves the requested interface pointer from the HTML element identified by `szElementId`.  
  
## Syntax  
  
```  
  
      template <class Q>  
HRESULT GetElementInterface(  
   LPCTSTR szElementId,  
   Q** ppvObj   
);  
HRESULT GetElementInterface(  
   LPCTSTR szElementId,  
   REFIID riid,  
   void** ppvObj   
);  
```  
  
#### Parameters  
 `szElementId`  
 The ID of an HTML element.  
  
 `ppvObj`  
 Address of a pointer that will be filled with the requested interface pointer if the element is found and the query succeeds.  
  
 `riid`  
 The interface ID (IID) of the requested interface.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Example  
 [!code[NVC_MFCHtmlHttp#4](../vs140/codesnippet/CPP/cdhtmldialog--getelementinterface_1.cpp)]
  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::GetElement](../vs140/cdhtmldialog--getelement.md)   
 [CDHtmlDialog::GetControlDispatch](../vs140/cdhtmldialog--getcontroldispatch.md)