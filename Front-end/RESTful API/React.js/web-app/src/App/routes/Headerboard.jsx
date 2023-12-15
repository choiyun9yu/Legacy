import React, { useState } from 'react';

import {HeaderboardHeader} from "../components/Headerboard/HeaderboardHeader";
import {HeaderboardMode1} from "../components/Headerboard/HeaderboardMode1";
import {HeaderboardMode2} from "../components/Headerboard/HeaderboardMode2";
import {HeaderboardMode3} from "../components/Headerboard/HeaderboardMode3";

export const Headerboard = () => {
    const [ mode, setMode ] = useState('one');

    return (
        <div id={"headerboard"} className={"flex flex-col w-full h-full"}>
            <HeaderboardHeader mode={mode} setMode={setMode} />
            <div className={"flex w-full h-full m-3 overflow-hidden"}>
                {mode === 'one' ? <HeaderboardMode1/> : null}
                {mode === 'two' ? <HeaderboardMode2/> : null}
                {mode === 'three' ? <HeaderboardMode3/> : null}
            </div>
        </div>
    )
};