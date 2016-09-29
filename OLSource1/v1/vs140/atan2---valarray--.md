---
title: "atan2 (&lt;valarray&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::atan2"
  - "std.atan2"
  - "atan2"
  - "valarray/std::atan2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atan2 function"
ms.assetid: fdf80ad4-958a-4485-b003-2b6fb344cbde
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atan2 (&lt;valarray&gt;)
Returns a valarray whose elements are equal to the arctangent of the Cartesian components specified by a combination of constants and elements of valarrays.  
  
## Syntax  
  
```  
  
      template<class Type>  
   valarray<Type> atan2(  
      const valarray<Type>& _Left,  
      const valarray<Type>& _Right  
   );  
template<class Type>  
   valarray<Type> atan2(  
      const valarray<Type> _Left,   
      const Type& _Right  
   );  
template<class Type>  
   valarray<Type> atan2(  
      const Type& _Left,   
      const valarray<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 The constant numerical data type or input valarray whose elements provide the values for the y-coordinate of the arctangent argument.  
  
 `_Right`  
 The constant numerical data type or input valarray whose elements provide the values for the x-coordinate of the arctangent argument.  
  
## Return Value  
 A valarray whose elements `I` are equal to the arctangent of:  
  
-   `_Left` [ *I* ] / *_Righ*t [ *I* ] for the first template function.  
  
-   `_Left` [ *I* ] / `_Right` for the second template function.  
  
-   `_Left` / `_Right` [ *I* ] for the third template function.  
  
## Remarks  
 The units of the returned elements are in radians.  
  
 This function preserves information about the signs of the components in the argument that is lost by the standard tangent function, and this knowledge of the quadrant enables the return value to be assigned a unique angle between +pi and –pi.  
  
 If `_Left` and `_Right` have a different number of elements, the result is undefined.  
  
## Example  
  
```  
// valarray_atan2.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
#include <iomanip>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
   int i;  
  
   valarray<double> va1y ( 1 , 4 ), va1x ( 1 , 4 );  
   va1x [ 1 ] = -1;  
   va1x [ 2 ] = -1;  
   va1y [ 2 ] = -1;  
   va1y [ 3 ] = -1;  
   valarray<double> va2 ( 4 );  
  
   cout << "The initial valarray for the x coordinate is: ( ";  
   for ( i = 0 ; i < 4 ; i++ )  
      cout << va1x [ i ] << " ";  
   cout << ")." << endl;  
  
   cout << "The initial valarray for the y coordinate is: ( ";  
   for ( i = 0 ; i < 4 ; i++ )  
      cout << va1y [ i ] << " ";  
   cout << ")." << endl;  
  
   va2 = atan2 ( va1y , va1x );  
   cout << "The atan2 ( y / x ) of the initial valarrays is:\n";  
   for ( i = 0 ; i < 4 ; i++ )  
      cout << setw( 10 ) << va2 [ i ]  
           << "  radians, which is  "  
           << setw( 11 ) << ( 180/pi ) * va2 [ i ]  
           << "degrees" << endl;  
   cout << endl;  
}  
```  
  
 **The initial valarray for the x coordinate is: ( 1 -1 -1 1 ).**  
**The initial valarray for the y coordinate is: ( 1 1 -1 -1 ).**  
**The atan2 ( y / x ) of the initial valarrays is:**  
 **0.785398  radians, which is           45degrees**  
 **2.35619  radians, which is          135degrees**  
 **-2.35619  radians, which is         -135degrees**  
 **-0.785398  radians, which is          -45degrees**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std