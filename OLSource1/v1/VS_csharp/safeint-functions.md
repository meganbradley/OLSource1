---
title: "SafeInt Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "functions, SafeInt"
ms.assetid: fdc208e5-5d8a-41a9-8271-567fd438958d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeInt Functions
The SafeInt library provides several functions that you can use without creating an instance of the [SafeInt Class](../VS_csharp/safeint-class.md). If you want to protect a single mathematical operation from integer overflow, you can use these functions. If you want to protect multiple mathematical operations, you should create `SafeInt` objects. It is more efficient to create `SafeInt` objects than to use these functions multiple times.  
  
 These functions enable you to compare or perform mathematical operations on two different types of parameters without having to convert them to the same type first.  
  
 Each of these functions has two template types: `T` and `U`. Each of these types can be a Boolean, character, or integral type. Integral types can be signed or unsigned and any size from 8 bits to 64 bits.  
  
## In This Section  
  
|Function|Description|  
|--------------|-----------------|  
|[SafeAdd](../VS_csharp/safeadd.md)|Adds two numbers and protects against overflow.|  
|[SafeCast](../VS_csharp/safecast.md)|Casts one type of parameter to another type.|  
|[SafeDivide](../VS_csharp/safedivide.md)|Divides two numbers and protects against dividing by zero.|  
|[SafeEquals](../VS_csharp/safeequals.md), [SafeGreaterThan](../VS_csharp/safegreaterthan.md), [SafeGreaterThanEquals](../VS_csharp/safegreaterthanequals.md), [SafeLessThan](../VS_csharp/safelessthan.md), [SafeLessThanEquals](../VS_csharp/safelessthanequals.md), [SafeNotEquals](../VS_csharp/safenotequals.md)|Compares two numbers. These functions enable you to compare two different types of numbers without changing their types.|  
|[SafeModulus](../VS_csharp/safemodulus.md)|Performs the modulus operation on two numbers.|  
|[SafeMultiply](../VS_csharp/safemultiply.md)|Multiplies two numbers together and protects against overflow.|  
|[SafeSubtract](../VS_csharp/safesubtract.md)|Subtracts two numbers and protects against overflow.|  
  
## Related Sections  
  
|Section|Description|  
|-------------|-----------------|  
|[SafeInt Class](../VS_csharp/safeint-class.md)|The `SafeInt` class.|  
|[SafeIntException Class](../VS_csharp/safeintexception-class.md)|The exception class specific to the SafeInt library.|