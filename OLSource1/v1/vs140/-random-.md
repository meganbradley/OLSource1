---
title: "&lt;random&gt;"
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
  - "<random>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "random header"
ms.assetid: 60afc25c-b162-4811-97c1-1b65398d4c57
caps.latest.revision: 58
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;random&gt;
Defines facilities for random number generation, allowing creation of uniformly distributed random numbers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Summary  
 A *random number generator* is an object that produces a sequence of pseudo-random values. A generator that produces values that are uniformly distributed in a specified range is a *Uniform Random Number Generator* (URNG). A template class designed to function as a URNG is referred to as an *engine* if that class has certain common traits, which are discussed later in this article. A URNG can be—and usually is—combined with a *distribution* by passing the URNG as an argument to the distribution's <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to produce values that are distributed in a manner that is defined by the distribution.  
  
 These links jump to the major sections of this article:  
  
-   [Code Examples](#code)  
  
-   [Categorized Listing](#listing)  
  
-   [Engines and Distributions](#engdist)  
  
-   [Remarks](#comments)  
  
### Quick Tips  
 Here are some tips to keep in mind when using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
-   For most purposes, URNGs produce raw bits that must be shaped by distributions. (A notable exception to this is [std::shuffle()](../vs140/-algorithm--functions.md#std__shuffle) because it uses a URNG directly.)  
  
-   A single instantiation of a URNG or distribution cannot safely be called concurrently because running a URNG or distribution is a modifying operation. For more information, see [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md).  
  
-   [Predefined typedefs](#typedefs) of several engines are provided; this is the preferred way to create a URNG if an engine is being used.  
  
-   The most useful pairing for most applications is the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> engine with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, as shown in the [code example](#code) later in this article.  
  
 There are many options to choose from in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> header, and any of them is preferable to the outdated C Runtime function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For information about what's wrong with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and how <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> addresses these shortcomings, see [this video](http://go.microsoft.com/fwlink/?LinkId=397615).  
  
##  \<a name="code">\</a> Examples  
 The following code example shows how to generate some random numbers in this case five of them using a generator created with non-deterministic seed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output:**  
  
 **2430338871 3531691818 2723770500 3252414483 3632920437** While these are high quality random numbers and different every time this program is run, they are not necessarily in a useful range. To control the range, use a uniform distribution as shown in the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output:**  
  
 **5 1 6 1 2** The next code example shows a more realistic set of use cases with uniformly distributed random number generators shuffling the contents of a vector and an array.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example Output and Code Remarks  
 **Using random_device URNG:**  
**Randomized vector: 5 -4 2 3 0 5 -2 0 4 2 -1 2 -4 -3 1 4 4 1 2 -2**  
**Randomized array: O Li V K C Ti N Mg Ne Sc Cl B Cr Mn Ca Al F P Na Be Si Ar Fe S He H**  
**--**  
**Using constant-seed mersenne twister URNG:**  
**Randomized vector: 3 -1 -5 0 0 5 3 -4 -3 -4 1 -3 0 -3 -2 -4 5 1 -1 -1**  
**Randomized array: Al O Ne Si Na Be C N Cr Mn H V F Sc Mg Fe K Ca S Ti B P Ar Cl Li He**  
**--**  
**Using non-deterministic-seed mersenne twister URNG:**  
**Randomized vector: 5 -4 0 2 1 -2 4 4 -4 0 0 4 -5 4 -5 -1 -3 0 0 3**  
**Randomized array: Si Fe Al Ar Na P B Sc H F Mg Li C Ti He N Mn Be O Ca Cr V K Ne Cl S**  
**--**  
**Using non-deterministic-seed "warm-up" sequence mersenne twister URNG:**  
**Randomized vector: -1 3 -2 4 1 3 0 -5 5 -5 0 0 5 0 -3 3 -4 2 5 0**  
**Randomized array: Si C Sc H Na O S Cr K Li Al Ti Cl B Mn He Fe Ne Be Ar V P Ca N Mg F**  
**--** This code demonstrates two different randomizations—randomize a vector of integers and shuffle an array of indexed data—with a test template function. The first call to the test function uses the crypto-secure, non-deterministic, not-seedable, non-repeatable URNG <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The second test run uses <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as URNG, with a deterministic 32-bit constant seed, which means the results are repeatable. The third test run seeds <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with a 32-bit non-deterministic result from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The fourth test run expands on this by using a [seed sequence](../vs140/seed_seq-class.md) filled with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> results, which effectively gives more than 32-bit non-deterministic randomness (but still not crypto-secure). For more information, read on.  
  
##  \<a name="listing">\</a> Categorized Listing  
  
###  \<a name="urngs">\</a> Uniform Random Number Generators  
 URNGs are often described in terms of these properties:  
  
1.  **Period length**: How many iterations it takes to repeat the sequence of numbers generated. The longer the better.  
  
2.  **Performance**: How quickly numbers can be generated and how much memory it takes. The smaller the better.  
  
3.  **Quality**: How close to true random numbers the generated sequence is. This is often called "*randomness*".  
  
 The following sections list the uniform random number generators (URNGs) provided in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> header.  
  
####  \<a name="rd">\</a> Non-Deterministic Generator  
  
|||  
|-|-|  
|[random_device](../vs140/random_device-class.md)|Generates a non-deterministic, cryptographically secure random sequence by using an external device. Usually used to seed an engine. Low performance, very high quality. For more information, see [Remarks](#comments).|  
  
####  \<a name="typedefs">\</a> Engine Typedefs with Predefined Parameters  
 For instantiating engines and engine adaptors. For more information, see [Engines and Distributions](#engdist).  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> The default engine.   
    <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> Knuth engine.   
    <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> 1988 minimal standard engine (Lewis, Goodman, and Miller, 1969).   
    <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> Updated minimal standard engine <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (Park, Miller, and Stockmeyer, 1993).   
    <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> 32-bit Mersenne twister engine (Matsumoto and Nishimura, 1998).   
    <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> 64-bit Mersenne twister engine (Matsumoto and Nishimura, 2000).   
    <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> 24-bit RANLUX engine (Martin Lüscher and Fred James, 1994).   
    <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> Used as a base for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.   
    <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> 48-bit RANLUX engine (Martin Lüscher and Fred James, 1994).   
    <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> Used as a base for <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.   
    <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
####  \<a name="eng">\</a> Engine Templates  
 Engine templates are used as standalone URNGs or as base engines passed to [engine adaptors](#engadapt). Usually these are instantiated with a [predefined engine typedef](#typedefs) and passed to a [distribution](#distributions). For more information, see the [Engines and Distributions](#engdist) section.  
  
|||  
|-|-|  
|[linear_congruential_engine](../vs140/linear_congruential_engine-class.md)|Generates a random sequence by using the linear congruential algorithm. Most simplistic and lowest quality.|  
|[mersenne_twister_engine](../vs140/mersenne_twister_engine-class.md)|Generates a random sequence by using the Mersenne twister algorithm. Most complex, and is highest quality except for the random_device class. Very fast performance.|  
|[subtract_with_carry_engine](../vs140/subtract_with_carry_engine-class.md)|Generates a random sequence by using the subtract-with-carry algorithm. An improvement on <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, but much lower quality and performance than <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
  
####  \<a name="engadapt">\</a> Engine Adaptor Templates  
 Engine adaptors are templates that adapt other (base) engines. Usually these are instantiated with a [predefined engine typedef](#typedefs) and passed to a [distribution](#distributions). For more information, see the [Engines and Distributions](#engdist) section.  
  
|||  
|-|-|  
|[discard_block_engine](../vs140/discard_block_engine-class.md)|Generates a random sequence by discarding values returned by its base engine.|  
|[independent_bits_engine](../vs140/independent_bits_engine-class.md)|Generates a random sequence with a specified number of bits by repacking bits from the values returned by its base engine.|  
|[shuffle_order_engine](../vs140/shuffle_order_engine-class.md)|Generates a random sequence by reordering the values returned from its base engine.|  
  
 [[go to top of section](#eng)]  
  
###  \<a name="distributions">\</a> Random Number Distributions  
 The following sections list the distributions provided in the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> header. Distributions are a post-processing mechanism, usually using URNG output as input and distributing the output by a defined statistical probability density function. For more information, see the [Engines and Distributions](#engdist) section.  
  
#### Uniform Distributions  
  
|||  
|-|-|  
|[uniform_int_distribution](../vs140/uniform_int_distribution-class.md)|Produces a uniform integer value distribution across a range in the closed interval [a, b] (inclusive- inclusive).|  
|[uniform_real_distribution](../vs140/uniform_real_distribution-class.md)|Produces a uniform real (floating-point) value distribution across a range in the interval [a, b) (inclusive-exclusive).|  
|[generate_canonical](../vs140/-random--functions.md#generate_canonical)|Produces an even distribution of real (floating point) values of a given precision across [0, 1) (inclusive-exclusive).|  
  
 [[go to top of section](#distributions)]  
  
#### Bernoulli Distributions  
  
|||  
|-|-|  
|[bernoulli_distribution](../vs140/bernoulli_distribution-class.md)|Produces a Bernoulli distribution of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> values.|  
|[binomial_distribution](../vs140/binomial_distribution-class.md)|Produces a binomial distribution of integer values.|  
|[geometric_distribution](../vs140/geometric_distribution-class.md)|Produces a geometric distribution of integer values.|  
|[negative_binomial_distribution](../vs140/negative_binomial_distribution-class.md)|Produces a negative binomial distribution of integer values.|  
  
 [[go to top of section](#distributions)]  
  
#### Normal Distributions  
  
|||  
|-|-|  
|[cauchy_distribution](../vs140/cauchy_distribution-class.md)|Produces a Cauchy distribution of real (floating point) values.|  
|[chi_squared_distribution](../vs140/chi_squared_distribution-class.md)|Produces a chi-squared distribution of real (floating point) values.|  
|[fisher_f_distribution](../vs140/fisher_f_distribution-class.md)|Produces an F-distribution (also known as Snedecor's F distribution or the Fisher–Snedecor distribution) of real (floating point) values.|  
|[lognormal_distribution](../vs140/lognormal_distribution-class.md)|Produces a log-normal distribution of real (floating point) values.|  
|[normal_distribution](../vs140/normal_distribution-class.md)|Produces a normal (Gaussian) distribution of real (floating point) values.|  
|[student_t_distribution](../vs140/student_t_distribution-class.md)|Produces a Student's *t*-distribution of real (floating point) values.|  
  
 [[go to top of section](#distributions)]  
  
#### Poisson Distributions  
  
|||  
|-|-|  
|[exponential_distribution](../vs140/exponential_distribution-class.md)|Produces an exponential distribution of real (floating point) values.|  
|[extreme_value_distribution](../vs140/extreme_value_distribution-class.md)|Produces an extreme value distribution of real (floating point) values.|  
|[gamma_distribution](../vs140/gamma_distribution-class.md)|Produces a gamma distribution of real (floating point) values.|  
|[poisson_distribution](../vs140/poisson_distribution-class.md)|Produces a Poisson distribution of integer values.|  
|[weibull_distribution](../vs140/weibull_distribution-class.md)|Produces a Weibull distribution of real (floating point) values.|  
  
 [[go to top of section](#distributions)]  
  
#### Sampling Distributions  
  
|||  
|-|-|  
|[discrete_distribution](../vs140/discrete_distribution-class.md)|Produces a discrete integer distribution.|  
|[piecewise_constant_distribution](../vs140/piecewise_constant_distribution-class.md)|Produces a piecewise constant distribution of real (floating point) values.|  
|[piecewise_linear_distribution](../vs140/piecewise_linear_distribution-class.md)|Produces a piecewise linear distribution of real (floating point) values.|  
  
 [[go to top of section](#distributions)]  
  
### Utility Functions  
 This section lists the general utility functions provided in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> header.  
  
|||  
|-|-|  
|[seed_seq](../vs140/seed_seq-class.md)|Generates a non-biased scrambled seed sequence. Used to avoid replication of random variate streams. Useful when many URNGs are instantiated from engines.|  
  
### Operators  
 This section lists the operators provided in the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> header.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Tests whether the URNG on the left side of the operator is equal to the engine on the right side.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Tests whether the URNG on the left side of the operator is not equal to the engine on the right side.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Writes state information to a stream.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Extracts state information from a stream.|  
  
##  \<a name="engdist">\</a> Engines and Distributions  
 Refer to the following sections for information about each of these template class categories defined in <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. Both of these template class categories take a type as an argument and use shared template parameter names to describe the properties of the type that are permitted as an actual argument type, as follows:  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> indicates a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> indicates <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> indicates a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
### Engines  
 [Engines](#eng) and [engine adaptors](#engadapt) are templates whose parameters customize the generator created.  
  
 An *engine* is a class or template class whose instances (generators) act as a source of random numbers uniformly distributed between a minimum and maximum value. An *engine adaptor* delivers a sequence of values that have different randomness properties by taking values produced by some other random number engine and applying an algorithm of some kind to those values.  
  
 Every engine and engine adaptor has the following members:  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is the type that is returned by the generator's <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is passed as a template parameter on instantiation.  
  
-   <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> returns values that are uniformly distributed between <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> returns the minimum value that is returned by the generator's <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. Engine adaptors use the base engine's <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> result.  
  
-   <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> returns the maximum value that is returned by the generator's <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is an integral (integer-valued) type, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is the maximum value that can actually be returned (inclusive); when <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is a floating-point (real-valued) type, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is the smallest value greater than all values that can be returned (non-inclusive). Engine adaptors use the base engine's <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> result.  
  
-   <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> seeds the generator with seed value <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. For engines, the signature is <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> for default parameter support (engine adaptors define a separate <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, see next subsection).  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> seeds the generator by using a [seed_seq](../vs140/seed_seq-class.md)<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
-   An explicit constructor with argument <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> that creates a generator seeded as if by calling <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
-   An explicit constructor with argument <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> that creates a generator seeded as if by calling <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> effectively calls <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> times and discards each value.  
  
 **Engine adaptors** additionally support these members (<CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is the first template parameter of an engine adaptor, designating the base engine's type):  
  
-   A default constructor to initialize the generator as if from the base engine's default constructor.  
  
-   An explicit constructor with argument <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. This is to support copy construction using the base engine.  
  
-   An explicit constructor with argument <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>. This is to support move construction using the base engine.  
  
-   <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> that initializes the generator with the base engine's default seed value.  
  
-   <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> property function that returns the base engine that was used to construct the generator.  
  
 Every engine maintains a *state* that determines the sequence of values that will be generated by subsequent calls to <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. The states of two generators instantiated from engines of the same type can be compared by using <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>. If the two states compare as equal, they will generate the same sequence of values. The state of an object can be saved to a stream as a sequence of 32-bit unsigned values by using the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> of the generator. The state is not changed by saving it. A saved state can be read into generator instantiated from an engine of the same type by using <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
### Distributions  
 A [distribution](#distributions) is a class or template class whose instances transform a stream of uniformly distributed random numbers obtained from an engine into a stream of random numbers that have a particular distribution. Every distribution has the following members:  
  
-   <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> is the type that is returned by the distribution's <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is passed as a template parameter on instantiation.  
  
-   <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> returns values that are distributed according to the distribution's definition, by using <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> as a source of uniformly distributed random values and the stored *parameters of the distribution*.  
  
-   <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> returns values distributed in accordance with the distribution's definition, using <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> as a source of uniformly distributed random values and the parameters structure <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is the package of parameters optionally passed to <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> and is used in place of the stored parameters to generate its return value.  
  
-   A <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> constructor initializes the stored parameters from its argument.  
  
-   <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> gets the stored parameters.  
  
-   <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> sets the stored parameters from its argument.  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> returns the minimum value that is returned by the distribution's <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> returns the maximum value that is returned by the distribution's <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> is an integral (integer-valued) type, <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> is the maximum value that can actually be returned (inclusive); when <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> is a floating-point (real-valued) type, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is the smallest value greater than all values that can be returned (non-inclusive).  
  
-   <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> discards any cached values, so that the result of the next call to <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> does not depend on any values obtained from the engine before the call.  
  
 A parameter structure is an object that stores all of the parameters needed for a distribution. It contains:  
  
-   <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, which is the type of its distribution.  
  
-   One or more constructors that take the same parameter lists as the distribution constructors take.  
  
-   The same parameter-access functions as the distribution.  
  
-   Equality and inequality comparison operators.  
  
 For more information, see the reference subtopics below this one, linked previously in this article.  
  
##  \<a name="comments">\</a> Remarks  
 There are two highly useful URNGs in Visual Studio—<CodeContentPlaceHolder>140\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>—as shown in this comparison table:  
  
|URNG|Fast?|Crypto-secure?|Seedable?|Deterministic?|  
|----------|-----------|---------------------|---------------|--------------------|  
|<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|Yes|No|Yes|Yes<sup>*\</sup>|  
|<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|No|Yes|No|No|  
  
 <sup>* When provided with a known seed.\</sup>  
  
 Although the ISO C++ Standard does not require <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> to be cryptographically secure, in Visual Studio it is implemented to be cryptographically secure. (The term "cryptographically secure" does not imply guarantees, but refers to a minimum level of entropy—and therefore, the level of predictability—a given randomization algorithm provides. For more information, see the Wikipedia article [Cryptographically secure pseudorandom number generator](http://go.microsoft.com/fwlink/?LinkId=398017).) Because the ISO C++ Standard does not require this, other platforms may implement <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> as a simple pseudo-random number generator (not cryptographically secure) and may only be suitable as a seed source for another generator. Check the documentation for those platforms when using <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> in cross-platform code.  
  
 By definition, <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> results are not reproducible, and a side-effect is that it may run significantly slower than other URNGs. Most applications that are not required to be cryptographically secure use <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> or a similar engine, although you may want to seed it with a call to <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, as shown in the [code example](#code).  
  
## See Also  
 [C++ Standard Library Header Files](../vs140/c---standard-library-header-files.md)