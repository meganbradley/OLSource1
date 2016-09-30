---
title: "How to: Read Object Data from an XML File (Visual Basic)"
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
ms.assetid: 1e1423bf-74a4-4dde-a3bb-ae1bfc0a68ed
caps.latest.revision: 8
---
# How to: Read Object Data from an XML File (Visual Basic)
This example reads object data that was previously written to an XML file using the \<xref:System.Xml.Serialization.XmlSerializer*> class.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
 Replace the file name "c:\temp\SerializationOverview.xml" with the name of the file containing the serialized data. For more information about serializing data, see [How to: Write Object Data to an XML File (Visual Basic)](../vs140/how-to--write-object-data-to-an-xml-file--visual-basic-.md).  
  
 The class must have a public constructor without parameters.  
  
 Only public properties and fields are deserialized.  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The class being serialized does not have a public, parameterless constructor.  
  
-   The data in the file does not represent data from the class to be deserialized.  
  
-   The file does not exist (\<xref:System.IO.IOException*>).  
  
## .NET Framework Security  
 Always verify inputs, and never deserialize data from an untrusted source. The re-created object runs on a local computer with the permissions of the code that deserialized it. Verify all inputs before using the data in your application.  
  
## See Also  
 \<xref:System.IO.StreamWriter*>   
 [How to: Write Object Data to an XML File (Visual Basic)](../vs140/how-to--write-object-data-to-an-xml-file--visual-basic-.md)   
 [Serialization (Visual Basic)](../vs140/serialization--visual-basic-.md)   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)