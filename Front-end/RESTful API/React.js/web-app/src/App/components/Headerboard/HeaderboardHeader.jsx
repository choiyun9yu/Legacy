export const HeaderboardHeader = (props) => {
    const handleMode1 = () => {
        props.setMode('one');
    }

    const handleMode2 = () => {
        props.setMode('two');
    }

    const handleMode3 = () => {
        props.setMode('three');
    }

    return (
        <div id={"hboard-header"} className={`flex m-1 border rounded-lg font-normal`}>
            {props.mode === 'one'
                ? (
                    <button className={`ml-1 mr-4 p-1 px-2 rounded-md border bg-green-500`}>
                        one
                    </button>
                )
                : (
                    <button className={`ml-1 mr-4 p-1 px-2 rounded-md border hover:text-white hover:bg-green-500`}
                            onClick={handleMode1}>
                        one
                    </button>
                )
            }

            {props.mode === 'two'
                ? (
                    <button className={`ml-1 mr-4 p-1 px-2 rounded-md border bg-yellow-400`}>
                        two
                    </button>
                )
                : (
                    <button className={`ml-1 mr-4 p-1 px-2 rounded-md border hover:text-white hover:bg-yellow-400`}
                            onClick={handleMode2}>
                        two
                    </button>
                )
            }

            {props.mode === 'three'
                ? (
                    <button className={`ml-1 mr-4 p-1 px-2 rounded-md border bg-red-600`}>
                        three
                    </button>
                )
                : (
                    <button className={`ml-1 mr-4 p-1 px-2 rounded-md border hover:text-white hover:bg-red-600`}
                            onClick={handleMode3}>
                        three
                    </button>
                )
            }

        </div>
    )
};