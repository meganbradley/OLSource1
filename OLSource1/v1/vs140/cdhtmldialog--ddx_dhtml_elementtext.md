---
title: "CDHtmlDialog::DDX_DHtml_ElementText"
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
  - CDHtmlDialog.DDX_DHtml_ElementText
  - CDHtmlDialog::DDX_DHtml_ElementText
  - DDX_DHtml_ElementText
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDX_DHtml_ElementText method
ms.assetid: 42a5c836-df5e-4064-89cb-440dbb87564f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::DDX_DHtml_ElementText
Exchanges data between a member variable and any HTML element property on an HTML page.  
  
## Syntax  
  
```  
  
      void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   CString& value   
);  
void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   short& value   
);  
void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   int& value   
);  
void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   long& value   
);  
void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   DWORD& value   
);  
void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   float& value   
);  
void DDX_DHtml_ElementText(  
   CDataExchange* pDX,  
   LPCTSTR szId,  
   DISPID dispid,  
   double& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 `szId`  
 The value that you specified for the HTML control's ID parameter.  
  
 *dispid*  
 The dispatch ID of the HTML element with which you want to exchange data.  
  
 *value*  
 The value being exchanged.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)