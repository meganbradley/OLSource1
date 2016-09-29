---
title: "How to: Read a Text File (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Read a Text File (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reading text files"
  - "text files, reading"
ms.assetid: 80551c01-d769-4b6d-8db7-fd53bde21b62
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read a Text File (C++-CLI)
The following code example demonstrates how to open and read a text file one line at a time, by using the <xref:System.IO.StreamReader*> class that's defined in the <xref:System.IO*?displayProperty=fullName> namespace. An instance of this class is used to open a text file and then the <xref:System.IO.StreamReader.ReadLine*?displayProperty=fullName> method is used to retrieve each line.  
  
 This code example reads a file that's named textfile.txt and contains text. For information about this kind of file, see [How to: Write a Text File](../vs140/how-to--write-a-text-file--c---cli-.md).  
  
## Example  
  
```  
// text_read.cpp  
// compile with: /clr  
#using<system.dll>  
using namespace System;  
using namespace System::IO;  
  
int main()  
{  
   String^ fileName = "textfile.txt";  
   try   
   {  
      Console::WriteLine("trying to open file {0}...", fileName);  
      StreamReader^ din = File::OpenText(fileName);  
  
      String^ str;  
      int count = 0;  
      while ((str = din->ReadLine()) != nullptr)   
      {  
         count++;  
         Console::WriteLine("line {0}: {1}", count, str );  
      }  
   }  
   catch (Exception^ e)  
   {  
      if (dynamic_cast<FileNotFoundException^>(e))  
         Console::WriteLine("file '{0}' not found", fileName);  
      else  
         Console::WriteLine("problem reading file '{0}'", fileName);  
   }  
  
   return 0;  
}  
```  
  
## See Also  
 [Working with I/O](assetId:///4f4a33a9-66b7-4cd7-a285-4ad3e4276cd2)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)