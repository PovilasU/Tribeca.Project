export default function Clients({ locations, updateSelection }) {

    function handler(location) {
        updateSelection(location);
    }

    const cients = ["Client A","Client B","Client C"];
    return (
        <div id="location-results" className="module">
            {cients.map((client, idx) => (
                <div className="location" key={idx}>
                    <div className="region">
                        <div>{client} </div>
                        <div className="subregion">test </div>
                    </div>
                
                </div>
            ))}
        </div>
    )
}