---
title: "Serialization: Serializing an Object"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "serializing objects [C++]"
  - "serialization [C++], objects"
  - "objects [C++], serializing"
ms.assetid: 1db772b1-ad55-4fcf-b133-126cca082510
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Serialization: Serializing an Object
The article [Serialization: Making a Serializable Class](../vs140/serialization--making-a-serializable-class.md) shows how to make a class serializable. Once you have a serializable class, you can serialize objects of that class to and from a file via a [CArchive](../vs140/carchive-class.md) object. This article explains:  
  
-   [What a CArchive object is](../vs140/what-is-a-carchive-object.md).  
  
-   [Two ways to create a CArchive](../vs140/two-ways-to-create-a-carchive-object.md).  
  
-   [How to use the CArchive <\< and >> operators](../vs140/using-the-carchive----and----operators.md).  
  
-   [Storing and loading CObjects via an archive](../vs140/storing-and-loading-cobjects-via-an-archive.md).  
  
 You can let the framework create the archive for your serializable document or explicitly create the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object yourself. You can transfer data between a file and your serializable object by using the <\< and >> operators for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or, in some cases, by calling the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived class.  
  
## See Also  
 [Serialization](../vs140/serialization-in-mfc.md)