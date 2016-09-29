---
title: "How to: Write Object Data to an XML File (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 7681eb98-703d-4005-a369-26a7bca0f894
caps.latest.revision: 8
---
# How to: Write Object Data to an XML File (C#)
TThis example writes the object from a class to an XML file using the <xref:System.Xml.Serialization.XmlSerializer*> class.  
  
## Example  
  
```c#  
public class XMLWrite  
{  
  
   static void Main(string[] args)  
    {  
        WriteXML();  
    }  
  
    public class Book  
    {  
        public String title;   
    }  
  
    public static void WriteXML()  
    {  
        Book overview = new Book();  
        overview.title = "Serialization Overview";  
        System.Xml.Serialization.XmlSerializer writer =   
            new System.Xml.Serialization.XmlSerializer(typeof(Book));  
  
        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";  
        System.IO.FileStream file = System.IO.File.Create(path);  
  
        writer.Serialize(file, overview);  
        file.Close();  
    }  
}  
```  
  
## Compiling the Code  
 The class must have a public constructor without parameters.  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The class being serialized does not have a public, parameterless constructor.  
  
-   The file exists and is read-only (<xref:System.IO.IOException*>).  
  
-   The path is too long (<xref:System.IO.PathTooLongException*>).  
  
-   The disk is full (<xref:System.IO.IOException*>).  
  
## .NET Framework Security  
 This example creates a new file, if the file does not already exist. If an application needs to create a file, that application needs `Create` access for the folder. If the file already exists, the application needs only `Write` access, a lesser privilege. Where possible, it is more secure to create the file during deployment, and only grant `Read` access to a single file, rather than `Create` access for a folder.  
  
## See Also  
 <xref:System.IO.StreamWriter*>   
 [How to: Read Object Data from an XML File (C#)](../vs140/how-to--read-object-data-from-an-xml-file--csharp-.md)   
 [Serialization (C# )](../vs140/serialization--csharp--.md)