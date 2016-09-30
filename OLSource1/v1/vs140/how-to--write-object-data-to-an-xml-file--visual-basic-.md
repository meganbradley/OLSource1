---
title: "How to: Write Object Data to an XML File (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: f7966480-5ed2-43ac-9894-33427436de2a
caps.latest.revision: 7
---
# How to: Write Object Data to an XML File (Visual Basic)
TThis example writes the object from a class to an XML file using the \<xref:System.Xml.Serialization.XmlSerializer*> class.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
 The class must have a public constructor without parameters.  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The class being serialized does not have a public, parameterless constructor.  
  
-   The file exists and is read-only (\<xref:System.IO.IOException*>).  
  
-   The path is too long (\<xref:System.IO.PathTooLongException*>).  
  
-   The disk is full (\<xref:System.IO.IOException*>).  
  
## .NET Framework Security  
 This example creates a new file, if the file does not already exist. If an application needs to create a file, that application needs <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> access for the folder. If the file already exists, the application needs only <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> access, a lesser privilege. Where possible, it is more secure to create the file during deployment, and only grant <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> access to a single file, rather than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> access for a folder.  
  
## See Also  
 \<xref:System.IO.StreamWriter*>   
 [How to: Read Object Data from an XML File (Visual Basic)](../vs140/how-to--read-object-data-from-an-xml-file--visual-basic-.md)   
 [Serialization (Visual Basic)](../vs140/serialization--visual-basic-.md)