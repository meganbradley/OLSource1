---
title: "&#39;&lt;interfacename&gt;.&lt;membername&gt;&#39; is already implemented by the base class &#39;&lt;baseclassname&gt;&#39;. Re-implementation of &lt;type&gt; assumed"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc42015"
  - "bc42015"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42015"
ms.assetid: 658c070a-113e-4bd8-b294-12c243191160
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;interfacename&gt;.&lt;membername&gt;&#39; is already implemented by the base class &#39;&lt;baseclassname&gt;&#39;. Re-implementation of &lt;type&gt; assumed
A property, procedure, or event in a derived class uses an `Implements` clause specifying an interface member that is already implemented in the base class.  
  
 A derived class can reimplement an interface member that is implemented by its base class. This is not the same as overriding the base class implementation. For more information, see [Implements (Visual Basic)](../VS_csharp/implements-clause--visual-basic-.md).  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../VS_csharp/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42015  
  
### To correct this error  
  
-   If you intend to reimplement the interface member, you do not need to take any action. Code in your derived class accesses the reimplemented member unless you use the `MyBase` keyword to access the base class implementation.  
  
-   If you do not intend to reimplement the interface member, remove the `Implements` clause from the property, procedure, or event declaration.  
  
## See Also  
 [Interfaces in Visual Basic](../VS_csharp/interfaces--visual-basic-.md)