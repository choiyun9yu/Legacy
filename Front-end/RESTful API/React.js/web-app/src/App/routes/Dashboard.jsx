import React, { useState } from 'react';

import { DashboardForm } from "../components/Dashboard/DashboardForm";
import { DashboardTable } from "../components/Dashboard/DashboardTable";

export const Dashboard = () => {
    const [ tableData, setTableData ] = useState([]);

    const dataTransfer = (data) => {
        setTableData(data);
    }

    return (
        <div id={"dashboard"}>
            <DashboardForm dataTransfer={dataTransfer}/>
            <DashboardTable tableData={tableData} />
        </div>
    )
};