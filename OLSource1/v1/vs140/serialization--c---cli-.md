---
title: "Serialization (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Serialization (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "serialization [C++]"
  - "SerializableAttribute class, managed applications"
  - "NonSerializedAttribute class, managed applications"
  - "managed code [C++], serializing"
  - ".NET Framework [C++], serialization"
  - "serialization [C++], about serialization"
ms.assetid: 869010ca-74e1-4989-b409-4643cdb94084
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Serialization (C++-CLI)
Serialization (the process of storing the state of an object or member to a permanent medium) of managed classes (including individual fields or properties) is supported by the \<xref:System.SerializableAttribute*> and \<xref:System.NonSerializedAttribute*> classes.  
  
## Remarks  
 Apply the **SerializableAttribute** custom attribute to a managed class to serialize the entire class or apply only to specific fields or properties to serialize parts of the managed class. Use the **NonSerializedAttribute** custom attribute to exempt fields or properties of a managed class from being serialized.  
  
## Example  
  
### Description  
 In the following example, the class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (and the property <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) is marked as serializable. However, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> property is not serialized as indicated by the **NonSerialized** custom attribute:  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Comments  
 Note that both attributes can be referenced using their "short name" (**Serializable** and **NonSerialized**). This is further explained in [Applying Attributes](assetId:///dd7604eb-9fa3-4b60-b2dd-b47739fa3148).  
  
## See Also  
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)