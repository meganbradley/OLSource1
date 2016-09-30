---
title: "CWnd::OnNcCreate"
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
  - "CWnd::OnNcCreate"
  - "CWnd.OnNcCreate"
  - "WM_NCCREATE"
  - "OnNcCreate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcCreate method"
  - "WM_NCCREATE"
ms.assetid: 7ccd61e6-a1b5-48a4-8781-85d3b5f1755d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcCreate
The framework calls this member function prior to the [WM_CREATE](../vs140/cwnd--oncreate.md) message when the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is first created.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the [CREATESTRUCT](../vs140/createstruct-structure.md) data structure for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if the nonclient area is created. It is 0 if an error occurs; the **Create** function will return **failure** in this case.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CWnd::CreateEx](../vs140/cwnd--createex.md)   
 [CWnd::OnNcCreate](../vs140/cwnd--onnccreate.md)