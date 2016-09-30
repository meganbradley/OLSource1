---
title: "Annotating Function Behavior"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_On_failure_"
  - "_Return_type_success_"
  - "_Always_"
  - "_Maybe_raises_SEH_exception_"
  - "_Raises_SEH_exception_"
  - "_Called_from_function_class_"
  - "_Function_class_"
  - "_Must_inspect_result_"
  - "_Success_"
  - "_Check_return_"
  - "_Use_decl_annotations_"
ms.assetid: c0aa268d-6fa3-4ced-a8c6-f7652b152e61
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Annotating Function Behavior
In addition to annotating [function parameters and return values](../vs140/annotating-function-parameters-and-return-values.md), you can annotate properties of the whole function.  
  
## Function Annotations  
 The following annotations apply to the function as a whole and describe how it behaves or what it expects to be true.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Not intended to stand alone; instead, it is a predicate to be used with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> annotation. For more information, see [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md).\<br />\<br /> The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is an arbitrary string that also appears in a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> annotation in the declaration of some functions.  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns nonzero if the function that is currently being analyzed is annotated by using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that has the same value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, it returns zero.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Annotates a return value and   states that the caller should inspect it. The checker reports an error if the function is called in a void context.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is an arbitrary string that is designated by the user.  It exists in a namespace that is distinct from other namespaces. A function, function pointer, or—most usefully—a function pointer type may be designated as belonging to one or more function classes.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Annotates a function that always raises a structured exception handler (SEH) exception, subject to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> conditions. For more information, see [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md).|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Annotates a function that may optionally raise an SEH exception, subject to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> conditions.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Annotates any output value, including the return value, parameters, and globals.  The analyzer reports an error if the value in the annotated object is not subsequently inspected. "Inspection" includes whether it is used in a conditional expression, is assigned to an output parameter or global, or is passed as a parameter.  For return values, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> implies <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|May be used on a function definition (also known as a function body) in place of the list of annotations in the header.  When <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is used, the annotations that appear on an in-scope header for the same function are used as if they are also present in the definition that has the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> annotation.|  
  
## Success/Failure Annotations  
 A function can fail, and when it does, its results may be incomplete or differ from the results when the function succeeds.  The annotations in the following list provide ways to express the failure behavior.  To use these annotations, you must enable them to determine success; therefore, a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> annotation is required.  Notice that <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> already have a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> annotation built into them; however, if you specify your own <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> annotation on <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, it overrides the built-in annotation.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Equivalent to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>; that is, the annotations in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> apply whether or not the function succeeds.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|To be used only when <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is also used to annotate the function—either explicitly, or implicitly through <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> on a typedef. When the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> annotation is present on a function parameter or return value, each annotation in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (anno) behaves as if it were coded as <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is the parameter to the required <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> annotation. This means that the implied application of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to all post-conditions does not apply for <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|May be applied to a typedef. Indicates that all functions that return that type and do not explicitly have <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> are annotated as if they had <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> cannot be used on a function or a function pointer typedef.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is an expression that yields an rvalue. When the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> annotation is present on a function declaration or definition, each annotation (<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>) on the function and in post-condition behaves as if it were coded as <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> annotation may be used only on a function, not on its parameters or return type. There can be at most one <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> annotation on a function, and it cannot be in any <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. For more information, see [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md).|  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Intrinsic Functions](../vs140/intrinsic-functions.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)