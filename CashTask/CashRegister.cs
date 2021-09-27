using System;
using System.Collections.Generic;
using System.Text;

namespace CashTask
{
    class CashRegister
    {
        
            public double TotalAmount;
            public Currency currency;
            public static int TotalSalesCount = 0;
            public PaymentType paymentType;
            public void AddNewSale(double saleprice, Currency currency1)
            {
                TotalSalesCount++;
                switch (currency1)
                {
                    case Currency.dollar:
                        TotalAmount += saleprice * 1.7;
                        break;
                    case Currency.azn:
                        TotalAmount += saleprice;
                        break;
                    case Currency.euro:
                        TotalAmount += saleprice * 2;
                        break;
                    case Currency.sterlinq:
                        TotalAmount += saleprice * 1.2;
                        break;
                    default:
                        break;
                }
            }
            public void RemoveSale(double saleprice, Currency currency1)
            {
                TotalSalesCount--;
            switch (currency1)
            {
                case Currency.dollar:
                    TotalAmount -= saleprice * 1.7;
                    break;
                case Currency.azn:
                    TotalAmount -= saleprice;
                    break;
                case Currency.euro:
                    TotalAmount -= saleprice * 2;
                    break;
                case Currency.sterlinq:
                    TotalAmount -= saleprice * 1.2;
                    break;
                default:
                    break;
            }
            
        }
        public CashRegister(double totalamount)
        {
            TotalAmount = totalamount;
        }

    }
    }

