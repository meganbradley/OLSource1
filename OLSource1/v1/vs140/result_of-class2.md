---
title: "result_of Class2"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "result_of Class"
f1_keywords: 
  - "functional/std::tr1::result_of"
  - "std::tr1::result_of"
  - "result_of"
  - "std.tr1.result_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "result_of class [TR1]"
ms.assetid: 14ec0040-07f1-45a5-80b5-d0c9f9b00c8f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# result_of Class2
The return type of a wrapped callable object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A description of a function call (see Remarks section).  
  
## Remarks  
 The template class defines its member                 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as a synonym for the return type of a function call described by its template argument                 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The template argument must be of the form                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, where                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a callable type. The template determines the return type according to the first of the following rules that applies:  
  
-   if                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a pointer to function type                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> the return type is                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>;  
  
-   if                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a reference to function type                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> the return type is                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>;  
  
-   if                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a pointer to member function type                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> the return type is                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>;  
  
-   if                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a pointer to data member type                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> the return type is                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>;  
  
-   if                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a class with a member typedef                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> the return type is                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>;  
  
-   if                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is 0 (that is,                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is of the form                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) the return type is                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>;  
  
-   if                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a class with a member template named                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> the return type is                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>;  
  
-   in all other cases it is an error.  
  
## Example  
 Â  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **val == 9**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std