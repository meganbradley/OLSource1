---
title: "enable_if Class"
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
  - "enable_if"
  - "std::tr1::enable_if"
  - "std.tr1.enable_if"
  - "std.enable_if"
  - "std::enable_if"
  - "type_traits/std::enable_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enable_if class[TR1]"
  - "enable_if"
ms.assetid: c6b8d41c-a18f-4e30-a39e-b3aa0e8fd926
caps.latest.revision: 30
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# enable_if Class
Conditionally makes an instance of a type for SFINAE overload resolution. The nested typedef <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> exists—and is a synonym for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>—if and only if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The value that determines the existence of the resulting type.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The type to instantiate if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is true.  
  
## Remarks  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is true, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has a nested typedef named "type" that's a synonym for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is false, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> doesn't have a nested typedef named "type".  
  
 This alias template is provided:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In C++, substitution failure of template parameters is not an error in itself—this is referred to as *SFINAE* (substitution failure is not an error). Typically, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is used to remove candidates from overload resolution—that is, it culls the overload set—so that one definition can be rejected in favor of another. This conforms to SFINAE behavior. For more information about SFINAE, see                 [Substitution failure is not an error](http://go.microsoft.com/fwlink/?LinkId=394798) on Wikipedia.  
  
 Here are four example scenarios:  
  
-   Scenario 1: Wrapping the return type of a function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Scenario 2: Adding a function parameter that has a default argument:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Scenario 3: Adding a template parameter that has a default argument:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   Scenario 4: If your function has a non-templated argument, you can wrap its type:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Scenario 1 doesn't work with constructors and conversion operators because they don't have return types.  
  
 Scenario 2 leaves the parameter unnamed. You could say <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, but the name <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is irrelevant, and giving it a name is likely to trigger an "unreferenced parameter" warning. You have to choose a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function parameter type and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> default argument.  You could say <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, but then users of your code could accidentally pass to the function an extra integer that would be ignored. Instead, we recommend that you use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and either <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> because almost nothing is convertible to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Scenario 2 also works for ordinary constructors.  However, it doesn't work for conversion operators because they can't take extra parameters.  It also doesn't work for [variadic](../vs140/ellipses-and-variadic-templates.md) constructors because adding extra parameters makes the function parameter pack a non-deduced context and thereby defeats the purpose of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Scenario 3 uses the name <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, but it's optional. Just " <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>" would work, but if you think that looks weird, you can use a "dummy" name—just don't use one that might also be used in the function definition. If you don't give a type to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, it defaults to void, and that's perfectly reasonable because you don't care what <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is. This works for everything, including conversion operators and [variadic](../vs140/ellipses-and-variadic-templates.md) constructors.  
  
 Scenario 4 works in constructors that don't have return types, and thereby solves the wrapping limitation of Scenario 1.  However, Scenario 4 is limited to non-templated function arguments, which aren't always available.  (Using Scenario 4 on a templated function argument prevents template argument deduction from working on it.)  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is powerful, but also dangerous if it's misused.  Because its purpose is to make candidates vanish before overload resolution, when it's misused, its effects can be very confusing.  Here are some recommendations:  
  
-   Do not use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to select between implementations at compile-time. Don't ever write one <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and another for <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  Instead, use a *tag dispatch* pattern—for example, an algorithm that selects implementations depending on the strengths of the iterators they're given.  
  
-   Do not use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to enforce requirements.  If you want to validate template parameters, and if the validation fails, cause an error instead of selecting another implementation, use [static_assert](../vs140/static_assert.md).  
  
-   Use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> when you have an overload set that makes otherwise good code ambiguous.  Most often, this occurs in implicitly converting constructors.  
  
## Example  
 This example explains how the STL template function [std::make_pair()](../vs140/-utility--functions.md#make_pair) takes advantage of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  In this example, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Overload resolution has to determine which <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> you want. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> has an implicitly converting constructor from <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  This isn't new—it was in C++98. However, in C++98/03, the implicitly converting constructor's signature always exists, even if it's <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  Overload resolution doesn't care that an attempt to instantiate that constructor explodes horribly because <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> isn't implicitly convertible to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>; it's only looking at signatures, before function definitions are instantiated.  Therefore, the example code is ambiguous, because signatures exist to convert <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to both <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
 C++11 solved this ambiguity by using <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to make sure <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> exists **only** when <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is implicitly convertible to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is implicitly convertible to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  This allows overload resolution to determine that <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is not convertible to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and that the overload that takes <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is viable.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)