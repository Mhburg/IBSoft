using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;
using Model;

namespace BOL
{
    public class SPYSTKOPTRepo : ISTKRepo, IOPTRepo
    {
        #region Events
        public event EventHandler<TickerPrice> STKTickPriceEvent;
        public event EventHandler<TickerPrice> OPTTickPriceEvent;
        public event EventHandler<TickSize> STKTickSizeEvent;
        public event EventHandler<TickSize> OPTTickSizeEvent;
        public event EventHandler<RTVolume> STKRTVolumeEvent;
        public event EventHandler<RTVolume> OPTRTVolumeEvent;
        #endregion

        #region Interface Implementation
        void ISTKRepo.accountDownloadEnd(string account)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.commissionReport(CommissionReport commissionReport)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.commissionReport(CommissionReport commissionReport)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.contractDetails(int reqId, ContractDetails contractDetails)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.contractDetails(int reqId, ContractDetails contractDetails)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.contractDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.contractDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.deltaNeutralValidation(int reqId, UnderComp underComp)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.deltaNeutralValidation(int reqId, UnderComp underComp)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.displayGroupList(int reqId, string groups)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.displayGroupList(int reqId, string groups)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.displayGroupUpdated(int reqId, string contractInfo)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.displayGroupUpdated(int reqId, string contractInfo)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.execDetails(int reqId, Contract contract, Execution execution)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.execDetails(int reqId, Contract contract, Execution execution)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.execDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.execDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.fundamentalData(int reqId, string data)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.fundamentalData(int reqId, string data)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.historicalData(int reqId, string date, double open, double high, double low, double close, int volume, int count, double WAP, bool hasGaps)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.historicalData(int reqId, string date, double open, double high, double low, double close, int volume, int count, double WAP, bool hasGaps)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.historicalDataEnd(int reqId, string startDate, string endDate)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.historicalDataEnd(int reqId, string startDate, string endDate)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.marketDataType(int reqId, int marketDataType)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.marketDataType(int reqId, int marketDataType)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.nextValidId(int orderId)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.nextValidId(int orderId)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.openOrderEnd()
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.openOrderEnd()
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.orderStatus(int orderId, string status, int filled, int remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.orderStatus(int orderId, string status, int filled, int remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.position(string account, Contract contract, int pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.position(string account, Contract contract, int pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.positionEnd()
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.positionEnd()
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.receiveFA(int faDataType, string faXmlData)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.receiveFA(int faDataType, string faXmlData)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureExpiry, double dividendImpact, double dividendsToExpiry)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureExpiry, double dividendImpact, double dividendsToExpiry)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickGeneric(int tickerId, int field, double value)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.tickGeneric(int tickerId, int field, double value)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickPrice(int tickerId, int field, double price, int canAutoExecute)
        {
            TickerPrice tp = new TickerPrice()
                                {
                                    Ticker_Id = tickerId,
                                    Field = field,
                                    Price = price,
                                    Can_Auto_Execute = canAutoExecute,
                                    TimeStamp = DateTime.Now.Ticks
                                };
            OPTTickPriceEvent(this, tp);
        }

        void ISTKRepo.tickPrice(int tickerId, int field, double price, int canAutoExecute)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickSize(int tickerId, int field, int size)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.tickSize(int tickerId, int field, int size)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickSnapshotEnd(int tickerId)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.tickSnapshotEnd(int tickerId)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.tickString(int tickerId, int tickType, string value)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.tickString(int tickerId, int tickType, string value)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.updateAccountTime(string timestamp)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.updateAccountValue(string key, string value, string currency, string accountName)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.updatePortfolio(Contract contract, int position, double marketPrice, double marketValue, double averageCost, double unrealisedPNL, double realisedPNL, string accountName)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.verifyCompleted(bool isSuccessful, string errorText)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.verifyCompleted(bool isSuccessful, string errorText)
        {
            throw new NotImplementedException();
        }

        void IOPTRepo.verifyMessageAPI(string apiData)
        {
            throw new NotImplementedException();
        }

        void ISTKRepo.verifyMessageAPI(string apiData)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
