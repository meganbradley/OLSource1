---
title: "CDHtmlDialog::DDX_DHtml_AxControl"
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
  - "DDX_DHtml_AxControl"
  - "CDHtmlDialog.DDX_DHtml_AxControl"
  - "CDHtmlDialog::DDX_DHtml_AxControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_DHtml_AxControl method"
ms.assetid: 1f50a5cb-3bfb-4072-8270-b7607aae298c
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::DDX_DHtml_AxControl
Exchanges data between a member variable and the property value of an ActiveX control on an HTML page.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of the object tag's ID parameter in the HTML source for the ActiveX control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The dispatch ID of the property with which you want to exchange data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of the property.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The data member, of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, [COleVariant](../vs140/colevariant-class.md), or [CComVariant](../vs140/ccomvariant-class.md), that holds the value exchanged with the ActiveX control property.  
  
## Example  
 [!code[NVC_MFCHtmlHttp#1](../vs140/codesnippet/CPP/cdhtmldialog--ddx_dhtml_axcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)