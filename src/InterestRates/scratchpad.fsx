// read: https://investinganswers.com/dictionary/i/interest-rate-swap
// read: https://www.investopedia.com/articles/active-trading/111414/how-value-interest-rate-swaps.asp


let compounded pv annualRate periodInYears = pv * (1. + annualRate) ** periodInYears 

compounded 1_000_000. 0.05 20.

[1..2]
|> Seq.fold (fun acc _ -> acc + (acc * 0.01) ) 1000.

let discounted pv annualRate periodInYears = pv * (1. + annualRate) ** -periodInYears 
discounted 1_000_000. 0.05 20.

// continue with Discount Rate on https://www.vertex42.com/ExcelArticles/discount-factors.html