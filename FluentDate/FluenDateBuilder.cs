using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace FluentDate
{
    /// <summary>
    /// Provides methods for building up a Fluent dateTime expression
    /// </summary>
    public class FluenDateBuilder : IDatePositioner,IDateQantifier
    {
        DateTime _sourceDateTime;
        int _calendarUnits;
        ExpressionType _expressionType;
        DateTimeUnitType _dateTimeUnitType;

        
        public FluenDateBuilder(DateTime sourceDateTime, 
                                int calendarUnits, 
                                ExpressionType expressionType)
        {

            _sourceDateTime = sourceDateTime;
            if (calendarUnits <= 0) throw new ArgumentException("Units must be postive numbers larger than zero.");
            _calendarUnits = calendarUnits;
            _expressionType = expressionType;
        }
        #region Public Methods
        

        public IDateQantifier Days {
            get      {
                _dateTimeUnitType = DateTimeUnitType.Day;
                return this;               
            }            
        }

        public IDateQantifier Weeks {
            get {
                _dateTimeUnitType = DateTimeUnitType.Week;
                return this;
            }
        }
        #region IDateQuantifier Implementatin

            public bool Before(DateTime targetDateTime)
            {
                return _sourceDateTime>targetDateTime?false:Evaluate(targetDateTime,_sourceDateTime );
            }

            public bool After(DateTime targetDateTime)
            {
                return _sourceDateTime<targetDateTime?false:Evaluate(_sourceDateTime,targetDateTime );
            }

            public bool Ago
            {
                get
                {
                    return Before(DateTime.Today);
                }
            }

            public bool FromNow
            {
                get
                {
                    return After(DateTime.Now);
                }
            }

            public bool FromToday
            {
                get
                {
                    return After(DateTime.Today);
                }
            }

        #endregion




        #endregion

        #region Private Methods

        private DateTime AddCalendarUnits(DateTime date)
        {
            DateTime newDateTime = date;
            switch (_dateTimeUnitType)
            {
                case DateTimeUnitType.Year:
                    newDateTime = date.AddYears(_calendarUnits);
                    break;
                case DateTimeUnitType.Month:
                    newDateTime = date.AddMonths(_calendarUnits);
                    break;
                case DateTimeUnitType.Week:
                    newDateTime = date.AddDays(_calendarUnits * 7);
                    break;
                case DateTimeUnitType.Day:
                    newDateTime = date.AddDays(_calendarUnits);
                    break;
                case DateTimeUnitType.Hour:
                    newDateTime = date.AddHours(_calendarUnits);
                    break;
                case DateTimeUnitType.Minute:
                    newDateTime = date.AddMinutes(_calendarUnits);
                    break;
                case DateTimeUnitType.Second:
                    newDateTime = date.AddSeconds(_calendarUnits);
                    break;
                default:
                    break;
            }

            return newDateTime;
        }

        private bool Evaluate(DateTime leftDateTime, DateTime rightDateTime)
        {
            //This affects which date is the source and which is the target.
            rightDateTime = AddCalendarUnits(rightDateTime);
            //Added a comment
            BinaryExpression binaryExpression =
            Expression.MakeBinary(
            _expressionType,
            Expression.Constant(leftDateTime),
            Expression.Constant(rightDateTime));

            return Expression.Lambda<Func<bool>>(binaryExpression).Compile()();
        }
        #endregion




        
    }
}
