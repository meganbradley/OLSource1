---
title: "How to: Retrieve Text from the Clipboard (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Retrieve Text from the Clipboard (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - text, retrieving from Clipboard
  - Clipboard, retrieving text
ms.assetid: 99e77ba0-8573-4030-92d8-de8aa7623ee4
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Retrieve Text from the Clipboard (C++-CLI)
The following code example uses the <xref:System.Windows.Forms.Clipboard.GetDataObject?qualifyHint=False> member function to return a pointer to the <xref:System.Windows.Forms.IDataObject?qualifyHint=False> interface. This interface can then be queried for the format of the data and used to retrieve the actual data.  
  
## Example  
  
```  
// read_clipboard.cpp  
// compile with: /clr  
#using <system.dll>  
#using <system.Drawing.dll>  
#using <system.windows.forms.dll>  
  
using namespace System;  
using namespace System::Windows::Forms;  
  
[STAThread] int main( )  
{  
   IDataObject^ data = Clipboard::GetDataObject( );  
  
   if (data)  
   {  
      if (data->GetDataPresent(DataFormats::Text))   
      {  
         String^ text = static_cast<String^>  
           (data->GetData(DataFormats::Text));  
         Console::WriteLine(text);   
      }  
      else  
         Console::WriteLine("Nontext data is in the Clipboard.");  
   }  
   else   
   {  
      Console::WriteLine("No data was found in the Clipboard.");  
   }  
  
   return 0;  
}  
```  
  
## See Also  
 [Windows Operations in C++](../vs140/windows-operations--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)