---
title: "locale Class"
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
  - "xlocale/std::locale"
  - "std::locale"
  - "std.locale"
  - "locale"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locale class"
ms.assetid: 7dd6d271-472d-4750-8fb5-ea8f55fbef62
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale Class
The class that describes a locale object that encapsulates culture-specific information as a set of facets that collectively define a specific localized environment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A facet is a pointer to an object of a class derived from class [facet](#facet_class) that has a public object of the form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can define an open-ended set of these facets. You can also construct a locale object that designates an arbitrary number of facets.  
  
 Predefined groups of these facets represent the [locale categories](#locale__category) traditionally managed in the Standard C Library by the function <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Category collate (LC_COLLATE) includes the facets:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Category ctype (LC_CTYPE) includes the facets:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Category monetary (LC_MONETARY) includes the facets:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Category numeric (LC_NUMERIC) includes the facets:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Category time (LC_TIME) includes the facets:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Category messages (LC_MESSAGES) includes the facets:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 (The last category is required by Posix, but not the C Standard.)  
  
 Some of these predefined facets are used by the iostreams classes, to control the conversion of numeric values to and from text sequences.  
  
 An object of class locale also stores a locale name as an object of class [string](../vs140/-string--typedefs.md#string). Using an invalid locale name to construct a locale facet or a locale object throws an object of class [runtime_error](../vs140/runtime_error-class.md). The stored locale name is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if the locale object cannot be certain that a C-style locale corresponds exactly to that represented by the object. Otherwise, you can establish a matching locale within the Standard C Library, for the locale object <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, by calling <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>(LC_ALL <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. [name](#locale__name)<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>).  
  
 In this implementation, you can also call the static member function:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 to construct a locale object that has no facets. It is also a transparent locale; if the template functions [has_facet](../vs140/-locale--functions.md#has_facet) and [use_facet](../vs140/-locale--functions.md#use_facet) cannot find the requested facet in a transparent locale, they consult first the global locale and then, if that is transparent, the classic locale. Thus, you can write:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Subsequent insertions to [cout](../vs140/-iostream--functions.md#cout) are mediated by the current state of the global locale. You can even write:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Numeric formatting rules for subsequent insertions to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> remain the same as in the C locale, even as the global locale supplies changing rules for inserting dates and monetary amounts.  
  
### Constructors  
  
|||  
|-|-|  
|[locale](#locale__locale)|Creates a locale, or a copy of a locale, or a copy of locale where a facet or a category has been replaced by a facet or category from another locale.|  
  
### Typedefs  
  
|||  
|-|-|  
|[category](#locale__category)|An integer type that provides bitmask values to denote standard facet families.|  
  
### Member Functions  
  
|||  
|-|-|  
|[combine](#locale__combine)|Inserts a facet from a specified locale into a target locale.|  
|[name](#locale__name)|Returns the stored locale name.|  
  
### Static Functions  
  
|||  
|-|-|  
|[classic](#locale__classic)|The static member function returns a locale object that represents the classic C locale.|  
|[global](#locale__global)|Resets the default local for the program.|  
  
### Operators  
  
|||  
|-|-|  
|[operator!=](#locale__operator_neq)|Tests two locales for inequality.|  
|[operator( )](#locale__operator__)|Compares two <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> objects.|  
|[operator==](#locale__operator_eq_eq)|Tests two locales for equality.|  
  
### Classes  
  
|||  
|-|-|  
|[facet](#facet_class)|A class that serves as the base class for all locale facets.|  
|[id](#id_class)|The member class provides a unique facet identification used as an index for looking up facets in a locale.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="locale__category">\</a>  locale::category  
 An integer type that provides bitmask values to denote standard facet families.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> type that can represent a group of distinct elements of a bitmask type local to class locale or can be used to represent any of the corresponding C locale categories. The elements are:  
  
-   **collate**, corresponding to the C category LC_COLLATE  
  
-   **ctype**, corresponding to the C category LC_CTYPE  
  
-   **monetary**, corresponding to the C category LC_MONETARY  
  
-   **numeric**, corresponding to the C category LC_NUMERIC  
  
-   **time**, corresponding to the C category LC_TIME  
  
-   **messages**, corresponding to the Posix category LC_MESSAGES  
  
 In addition, two useful values are:  
  
-   **none**, corresponding to none of the C categories  
  
-   **all**, corresponding to the C union of all categories LC_ALL  
  
 You can represent an arbitrary group of categories by using <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> with these constants, as in **monetary** &#124; **time**.  
  
##  \<a name="locale__classic">\</a>  locale::classic  
 The static member function returns a locale object that represents the classic C locale.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the C locale.  
  
### Remarks  
 The classic C locale is the U.S. English ASCII locale within the Standard C Library that is implicitly used in programs that are not internationalized.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The name of the previous locale is: C.**  
**The name of the current locale is: German_Germany.1252.**  
**The previous locale was classic.**  
**The current locale is not classic.**    
##  \<a name="locale__combine">\</a>  locale::combine  
 Inserts a facet from a specified locale into a target locale.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The locale containing the facet to be inserted into the target locale.  
  
### Return Value  
 The member function returns a locale object that replaces in or adds to **\*this** the facet <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> listed in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="facet_class">\</a>  facet Class  
 A class that serves as the base class for all locale facets.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 Note that you cannot copy or assign an object of class facet. You can construct and destroy objects derived from class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> but not objects of the base class proper. Typically, you construct an object <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> derived from facet when you construct a locale, as in **localeloc**( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>( ), **new**<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>);  
  
 In such cases, the constructor for the base class facet should have a zero <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> argument. When the object is no longer needed, it is deleted. Thus, you supply a nonzero _                        *Refs* argument only in those rare cases where you take responsibility for the lifetime of the object.  
  
##  \<a name="locale__global">\</a>  locale::global  
 Resets the default locale for the program. This affects the global locale for both C and C++.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The locale to be used as the default locale by the program.  
  
### Return Value  
 The previous locale before the default locale was reset.  
  
### Remarks  
 At program startup, the global locale is the same as the classic locale. The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> function calls <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to establish a matching locale in the Standard C library.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The initial locale is: C**  
**The current locale is: German_Germany.1252**  
**The previous locale was: C**    
##  \<a name="id_class">\</a>  id Class  
 The member class provides a unique facet identification used as an index for looking up facets in a locale.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The member class describes the static member object required by each unique locale facet. Note that you cannot copy or assign an object of class **id**.  
  
##  \<a name="locale__locale">\</a>  locale::locale  
 Creates a locale, or a copy of a locale, or a copy of locale where a facet or a category has been replaced by a facet or category from another locale.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Name of a locale.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A locale that is to be copied in constructing the new locale.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A locale from which to select a category.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The category to be substituted into the constructed locale.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The facet to be substituted into the constructed locale.  
  
### Remarks  
 The first constructor initializes the object to match the global locale. The second and third constructors initialize all the locale categories to have behavior consistent with the locale name <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. The remaining constructors copy <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, with the exceptions noted:  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
 replaces from <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> those facets corresponding to a category C for which C & <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is nonzero.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
 replaces from <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> those facets corresponding to a category C for which C & <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>is nonzero.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
 replaces in (or adds to) <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> the facet <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is not a null pointer.  
  
 If a locale name <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is a null pointer or otherwise invalid, the function throws [runtime_error](../vs140/runtime_error-class.md).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="locale__name">\</a>  locale::name  
 Returns the stored locale name.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A string giving the name of the locale.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **The name of the previous locale is: C.**  
**The name of the current locale is: German_Germany.1252.**    
##  \<a name="locale__operator_neq">\</a>  locale::operator!=  
 Tests two locales for inequality.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 One of the locales to be tested for inequality.  
  
### Return Value  
 A Boolean value that is **true** if the locales are not copies of the same locale; **false** if the locales are copies of the same locale.  
  
### Remarks  
 Two locales are equal if they are the same locale, if one is a copy of the other, or if they have identical names.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **locales loc1 (German_Germany.1252) and**  
 **loc2 (German_Germany.1252) are equal.**  
**locales loc1 (German_Germany.1252) and**  
 **loc3 (English_United States.1252) are not equal.**    
##  \<a name="locale__operator__">\</a>  locale::operator()  
 Compares two <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The left string.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The right string.  
  
### Return Value  
 The member function returns:  
  
-   –1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
### Remarks  
 The member function effectively executes:  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Thus, you can use a locale object as a function object.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **0**  
**0**    
##  \<a name="locale__operator_eq_eq">\</a>  locale::operator==  
 Tests two locales for equality.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 One of the locales to be tested for equality.  
  
### Return Value  
 A Boolean value that is **true** if the locales are copies of the same locale; **false** if the locales are not copies of the same locale.  
  
### Remarks  
 Two locales are equal if they are the same locale, if one is a copy of the other, or if they have identical names.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **locales loc1 (German_Germany.1252)**  
 **and loc2 (German_Germany.1252) are equal.**  
**locales loc1 (German_Germany.1252)**  
 **and loc3 (English_United States.1252) are not equal.**    
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [Code Pages](../vs140/code-pages.md)   
 [Locale Names, Languages, and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)