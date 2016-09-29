---
title: "How to: Write a Binary File (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Write a Binary File (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary files, writing in C++"
  - "files [C++], binary"
ms.assetid: 35d97ee6-fc7e-4c36-be18-8bbb3b44b3ae
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write a Binary File (C++-CLI)
The following code example demonstrates writing binary data to a file. Two classes from the <xref:System.IO*> namespace are used: <xref:System.IO.FileStream*> and <xref:System.IO.BinaryWriter*>. <xref:System.IO.FileStream*> represents the actual file, while <xref:System.IO.BinaryWriter*> provides an interface to the stream that allows binary access.  
  
 The following code example writes a file containing integers in binary format. This file can be read with the code in [How to: Read a Binary File](../vs140/how-to--read-a-binary-file--c---cli-.md).  
  
## Example  
  
```  
// binary_write.cpp  
// compile with: /clr  
#using<system.dll>  
using namespace System;  
using namespace System::IO;  
  
int main()  
{  
   array<Int32>^ data = {1, 2, 3, 10000};  
  
   FileStream^ fs = gcnew FileStream("data.bin", FileMode::Create);  
   BinaryWriter^ w = gcnew BinaryWriter(fs);  
  
   try   
   {  
      Console::WriteLine("writing data to file:");  
      for (int i=0; i<data->Length; i++)  
      {  
         Console::WriteLine(data[i]);  
         w->Write(data[i]);  
      }  
   }  
   catch (Exception^)   
   {  
     Console::WriteLine("data could not be written");  
     fs->Close();  
     return -1;  
   }  
  
   fs->Close();  
   return 0;  
}  
```  
  
## See Also  
 [Working with I/O](assetId:///4f4a33a9-66b7-4cd7-a285-4ad3e4276cd2)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)