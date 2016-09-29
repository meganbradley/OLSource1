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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Math Functions (Visual Basic)
The methods of the <xref:System.Math*?displayProperty=fullName> class provide trigonometric, logarithmic, and other common mathematical functions.  
  
## Remarks  
 The following table lists methods of the <xref:System.Math*?displayProperty=fullName> class. You can use these in a Visual Basic program.  
  
|.NET Framework method|Description|  
|---------------------------|-----------------|  
|<xref:System.Math.Abs*>|Returns the absolute value of a number.|  
|[Acos](assetId:///M:System.Math.Acos(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the angle whose cosine is the specified number.|  
|[Asin](assetId:///M:System.Math.Asin(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the angle whose sine is the specified number.|  
|[Atan](assetId:///M:System.Math.Atan(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the angle whose tangent is the specified number.|  
|[Atan2](assetId:///M:System.Math.Atan2(System.Double,System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the angle whose tangent is the quotient of two specified numbers.|  
|[BigMul](assetId:///M:System.Math.BigMul(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns the full product of two 32-bit numbers.|  
|<xref:System.Math.Ceiling*>|Returns the smallest integral value that's greater than or equal to the specified `Decimal` or `Double`.|  
|[Cos](assetId:///M:System.Math.Cos(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the cosine of the specified angle.|  
|[Cosh](assetId:///M:System.Math.Cosh(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the hyperbolic cosine of the specified angle.|  
|<xref:System.Math.DivRem*>|Returns the quotient of two 32-bit or 64-bit signed integers, and also returns the remainder in an output parameter.|  
|[Exp](assetId:///M:System.Math.Exp(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns e (the base of natural logarithms) raised to the specified power.|  
|<xref:System.Math.Floor*>|Returns the largest integer that's less than or equal to the specified `Decimal` or `Double` number.|  
|[IEEERemainder](assetId:///M:System.Math.IEEERemainder(System.Double,System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the remainder that results from the division of a specified number by another specified number.|  
|<xref:System.Math.Log*>|Returns the natural (base e) logarithm of a specified number or the logarithm of a specified number in a specified base.|  
|[Log10](assetId:///M:System.Math.Log10(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the base 10 logarithm of a specified number.|  
|<xref:System.Math.Max*>|Returns the larger of two numbers.|  
|<xref:System.Math.Min*>|Returns the smaller of two numbers.|  
|[Pow](assetId:///M:System.Math.Pow(System.Double,System.Double)?qualifyHint=False&autoUpgrade=True)|Returns a specified number raised to the specified power.|  
|<xref:System.Math.Round*>|Returns a `Decimal` or `Double` value rounded to the nearest integral value or to a specified number of fractional digits.|  
|<xref:System.Math.Sign*>|Returns an `Integer` value indicating the sign of a number.|  
|[Sin](assetId:///M:System.Math.Sin(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the sine of the specified angle.|  
|[Sinh](assetId:///M:System.Math.Sinh(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the hyperbolic sine of the specified angle.|  
|[Sqrt](assetId:///M:System.Math.Sqrt(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the square root of a specified number.|  
|[Tan](assetId:///M:System.Math.Tan(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the tangent of the specified angle.|  
|[Tanh](assetId:///M:System.Math.Tanh(System.Double)?qualifyHint=False&autoUpgrade=True)|Returns the hyperbolic tangent of the specified angle.|  
|<xref:System.Math.Truncate*>|Calculates the integral part of a specified `Decimal` or `Double` number.|  
  
 To use these functions without qualification, import the <xref:System.Math*?displayProperty=fullName> namespace into your project by adding the following code to the top of your source file:  
  
```  
Imports System.Math  
```  
  
## Example  
 This example uses the [Abs](assetId:///M:System.Math.Abs(System.Double)?qualifyHint=False&autoUpgrade=True) method of the <xref:System.Math*> class to compute the absolute value of a number.  
  
```  
' Returns 50.3.  
Dim MyNumber1 As Double = Math.Abs(50.3)  
' Returns 50.3.  
Dim MyNumber2 As Double = Math.Abs(-50.3)  
```  
  
## Example  
 This example uses the assetId:///M:System.Math.Atan(System.Double)?qualifyHint=False&autoUpgrade=True method of the <xref:System.Math*> class to calculate the value of pi.  
  
```  
Public Function GetPi() As Double  
    ' Calculate the value of pi.  
    Return 4.0 * Math.Atan(1.0)  
End Function  
```  
  
## Example  
 This example uses the assetId:///M:System.Math.Cos(System.Double)?qualifyHint=False&autoUpgrade=True method of the <xref:System.Math*> class to return the cosine of an angle.  
  
```  
Public Function Sec(ByVal angle As Double) As Double  
    ' Calculate the secant of angle, in radians.  
    Return 1.0 / Math.Cos(angle)  
End Function  
```  
  
## Example  
 This example uses the assetId:///M:System.Math.Exp(System.Double)?qualifyHint=False&autoUpgrade=True method of the <xref:System.Math*> class to return e raised to a power.  
  
```  
Public Function Sinh(ByVal angle As Double) As Double  
    ' Calculate hyperbolic sine of an angle, in radians.  
    Return (Math.Exp(angle) - Math.Exp(-angle)) / 2.0  
End Function  
```  
  
## Example  
 This example uses the [Log](assetId:///M:System.Math.Log(System.Double)?qualifyHint=False&autoUpgrade=True) method of the <xref:System.Math*> class to return the natural logarithm of a number.  
  
```  
Public Function Asinh(ByVal value As Double) As Double  
    ' Calculate inverse hyperbolic sine, in radians.  
    Return Math.Log(value + Math.Sqrt(value * value + 1.0))  
End Function  
```  
  
## Example  
 This example uses the [Round](assetId:///M:System.Math.Round(System.Double)?qualifyHint=False&autoUpgrade=True) method of the <xref:System.Math*> class to round a number to the nearest integer.  
  
```  
' Returns 3.  
Dim MyVar2 As Double = Math.Round(2.8)  
```  
  
## Example  
 This example uses the [Sign](assetId:///M:System.Math.Sign(System.Double)?qualifyHint=False&autoUpgrade=True) method of the <xref:System.Math*> class to determine the sign of a number.  
  
```  
' Returns 1.  
Dim MySign1 As Integer = Math.Sign(12)  
' Returns -1.  
Dim MySign2 As Integer = Math.Sign(-2.4)  
' Returns 0.  
Dim MySign3 As Integer = Math.Sign(0)  
```  
  
## Example  
 This example uses the assetId:///M:System.Math.Sin(System.Double)?qualifyHint=False&autoUpgrade=True method of the <xref:System.Math*> class to return the sine of an angle.  
  
```  
Public Function Csc(ByVal angle As Double) As Double  
    ' Calculate cosecant of an angle, in radians.  
    Return 1.0 / Math.Sin(angle)  
End Function  
```  
  
## Example  
 This example uses the assetId:///M:System.Math.Sqrt(System.Double)?qualifyHint=False&autoUpgrade=True method of the <xref:System.Math*> class to calculate the square root of a number.  
  
```  
' Returns 2.  
Dim MySqr1 As Double = Math.Sqrt(4)  
' Returns 4.79583152331272.  
Dim MySqr2 As Double = Math.Sqrt(23)  
' Returns 0.  
Dim MySqr3 As Double = Math.Sqrt(0)  
' Returns NaN (not a number).  
Dim MySqr4 As Double = Math.Sqrt(-4)  
```  
  
## Example  
 This example uses the assetId:///M:System.Math.Tan(System.Double)?qualifyHint=False&autoUpgrade=True method of the <xref:System.Math*> class to return the tangent of an angle.  
  
```  
Public Function Ctan(ByVal angle As Double) As Double  
    ' Calculate cotangent of an angle, in radians.  
    Return 1.0 / Math.Tan(angle)  
End Function  
```  
  
## Requirements  
 **Class:** <xref:System.Math*>  
  
 **Namespace:** <xref:System*>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
## See Also  
 <xref:Microsoft.VisualBasic.VBMath.Rnd*>   
 <xref:Microsoft.VisualBasic.VBMath.Randomize*>   
 <xref:System.Double.NaN*>   
 [Derived Math Functions](../vs140/derived-math-functions--visual-basic-.md)   
 [Arithmetic Operators (Visual Basic)](../vs140/arithmetic-operators--visual-basic-.md)