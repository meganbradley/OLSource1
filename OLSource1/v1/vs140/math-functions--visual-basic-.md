---
title: "Math Functions (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "math functions, Visual Basic"
  - "arithmetic operations, math functions"
  - "math routines"
  - "Atn function"
ms.assetid: 4d2d82e7-6924-42fe-a4a7-b4dd5bebbd0c
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Math Functions (Visual Basic)
The methods of the \<xref:System.Math*?displayProperty=fullName> class provide trigonometric, logarithmic, and other common mathematical functions.  
  
## Remarks  
 The following table lists methods of the \<xref:System.Math*?displayProperty=fullName> class. You can use these in a Visual Basic program.  
  
|.NET Framework method|Description|  
|---------------------------|-----------------|  
|\<xref:System.Math.Abs*>|Returns the absolute value of a number.|  
|\<xref:System.Math.Acos*>|Returns the angle whose cosine is the specified number.|  
|\<xref:System.Math.Asin*>|Returns the angle whose sine is the specified number.|  
|\<xref:System.Math.Atan*>|Returns the angle whose tangent is the specified number.|  
|\<xref:System.Math.Atan2*>|Returns the angle whose tangent is the quotient of two specified numbers.|  
|\<xref:System.Math.BigMul*>|Returns the full product of two 32-bit numbers.|  
|\<xref:System.Math.Ceiling*>|Returns the smallest integral value that's greater than or equal to the specified <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|\<xref:System.Math.Cos*>|Returns the cosine of the specified angle.|  
|\<xref:System.Math.Cosh*>|Returns the hyperbolic cosine of the specified angle.|  
|\<xref:System.Math.DivRem*>|Returns the quotient of two 32-bit or 64-bit signed integers, and also returns the remainder in an output parameter.|  
|\<xref:System.Math.Exp*>|Returns e (the base of natural logarithms) raised to the specified power.|  
|\<xref:System.Math.Floor*>|Returns the largest integer that's less than or equal to the specified <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> number.|  
|\<xref:System.Math.IEEERemainder*>|Returns the remainder that results from the division of a specified number by another specified number.|  
|\<xref:System.Math.Log*>|Returns the natural (base e) logarithm of a specified number or the logarithm of a specified number in a specified base.|  
|\<xref:System.Math.Log10*>|Returns the base 10 logarithm of a specified number.|  
|\<xref:System.Math.Max*>|Returns the larger of two numbers.|  
|\<xref:System.Math.Min*>|Returns the smaller of two numbers.|  
|\<xref:System.Math.Pow*>|Returns a specified number raised to the specified power.|  
|\<xref:System.Math.Round*>|Returns a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value rounded to the nearest integral value or to a specified number of fractional digits.|  
|\<xref:System.Math.Sign*>|Returns an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value indicating the sign of a number.|  
|\<xref:System.Math.Sin*>|Returns the sine of the specified angle.|  
|\<xref:System.Math.Sinh*>|Returns the hyperbolic sine of the specified angle.|  
|\<xref:System.Math.Sqrt*>|Returns the square root of a specified number.|  
|\<xref:System.Math.Tan*>|Returns the tangent of the specified angle.|  
|\<xref:System.Math.Tanh*>|Returns the hyperbolic tangent of the specified angle.|  
|\<xref:System.Math.Truncate*>|Calculates the integral part of a specified <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> number.|  
  
 To use these functions without qualification, import the \<xref:System.Math*?displayProperty=fullName> namespace into your project by adding the following code to the top of your source file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Abs*> method of the \<xref:System.Math*> class to compute the absolute value of a number.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Atan*> method of the \<xref:System.Math*> class to calculate the value of pi.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Cos*> method of the \<xref:System.Math*> class to return the cosine of an angle.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Exp*> method of the \<xref:System.Math*> class to return e raised to a power.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Log*> method of the \<xref:System.Math*> class to return the natural logarithm of a number.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Round*> method of the \<xref:System.Math*> class to round a number to the nearest integer.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Sign*> method of the \<xref:System.Math*> class to determine the sign of a number.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Sin*> method of the \<xref:System.Math*> class to return the sine of an angle.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Sqrt*> method of the \<xref:System.Math*> class to calculate the square root of a number.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Example  
 This example uses the \<xref:System.Math.Tan*> method of the \<xref:System.Math*> class to return the tangent of an angle.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Requirements  
 **Class:** \<xref:System.Math*>  
  
 **Namespace:** \<xref:System*>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
## See Also  
 \<xref:Microsoft.VisualBasic.VBMath.Rnd*>   
 \<xref:Microsoft.VisualBasic.VBMath.Randomize*>   
 \<xref:System.Double.NaN*>   
 [Derived Math Functions](../vs140/derived-math-functions--visual-basic-.md)   
 [Arithmetic Operators (Visual Basic)](../vs140/arithmetic-operators--visual-basic-.md)