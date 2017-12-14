# 航班预定查询系统
*数据库课程设计*

## 功能描述
根据出发地和目的地以及出发时间段来进行航班的预定，其中航班预定必须在现实对应时间之后。

## 实体属性图
![entity](https://github.com/JasonLin1230/flight-reservation-system/blob/master/Img/entity.jpg?raw=true)

## E-R图
![entity](https://github.com/JasonLin1230/flight-reservation-system/blob/master/Img/E-R.png?raw=true)

## 逻辑设计
* 航空公司表（公司ID，公司名称）
* 城市信息表（城市ID，城市名称）
* 航班信息表（航班号，航空公司ID，离开城市，到达城市，离开时间，到达时间，单价，时间段）
* 订单信息表（订单ID，航班号，离开时间，到达时间，总价，订单数量）