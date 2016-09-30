---
title: "&#39;Class_Initialize&#39; event is no longer supported"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc42001"
  - "bc42001"
helpviewer_keywords: 
  - "BC42001"
ms.assetid: 31e7c383-894e-416c-b834-3688cc340ccf
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Class_Initialize&#39; event is no longer supported
'Class_Initialize' event is no longer supported. Use 'Sub New' to initialize a class.  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> event of previous versions of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is replaced by class constructors.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42001  
  
### To correct this error  
  
-   Declare one or more <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedures named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to initialize a class. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called when a class instance is newly created.  
  
## See Also  
 [Class_Initialize Changes in Visual Basic](assetId:///2cd023cf-2869-4836-b08d-43822294beeb)   
 [Classes for Visual Basic 6.0 Users](assetId:///d625222c-cd32-4c8d-b25c-ea71729b88b7)   
 [NOT IN BUILD: Using Constructors and Destructors](assetId:///548eebe1-86c4-4377-b2f5-447cb8be3d90)