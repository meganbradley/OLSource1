---
title: "basic_ios::exceptions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "basic_ios.exceptions"
  - "exceptions"
  - "std.basic_ios.exceptions"
  - "basic_ios::exceptions"
  - "std::basic_ios::exceptions"
  - "ios/std::basic_ios::exceptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exceptions method"
ms.assetid: c0c3e97b-b8a6-4917-b824-47923c977ed1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::exceptions
Indicates which exceptions will be thrown by the stream.  
  
## Syntax  
  
```  
iostate exceptions( ) const;  
void exceptions(  
    iostate _Newexcept  
);  
void exceptions(  
    io_state _Newexcept  
);  
```  
  
#### Parameters  
 *_Newexcept*  
 The flags that you want to throw an exception.  
  
## Return Value  
 The flags that are currently specified to thrown an exception for the stream.  
  
## Remarks  
 The first member function returns the stored exception mask. The second member function stores *_Except* in the exception mask and returns its previous stored value. Note that storing a new exception mask can throw an exception just like the call [clear](../vs140/basic_ios--clear.md)( [rdstate](../vs140/basic_ios--rdstate.md) ).  
  
## Example  
  
```  
// basic_ios_exceptions.cpp  
// compile with: /EHsc /GR  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   cout << cout.exceptions( ) << endl;  
   cout.exceptions( ios::eofbit );  
   cout << cout.exceptions( ) << endl;  
   try   
   {  
      cout.clear( ios::eofbit );   // Force eofbit on  
   }  
   catch ( exception &e )   
   {  
      cout.clear( );  
      cout << "Caught the exception." << endl;  
      cout << "Exception class: " << typeid(e).name()  << endl;  
      cout << "Exception description: " << e.what() << endl;  
   }  
}  
```  
  
 **0**  
**1**  
**Caught the exception.**  
**Exception class: class std::ios_base::failure**  
**Exception description: ios_base::eofbit set**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)