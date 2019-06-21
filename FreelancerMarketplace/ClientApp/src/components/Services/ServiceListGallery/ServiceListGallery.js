import React, { Component } from 'react';
import './ServiceListGallery.css';

export class ServiceListGallery extends Component {
    constructor(props) {
        super();
        this.state = {
            img_path: props.imgPath,
            img_name: props.imgName,
            error: null
        }
    }

    anotherImage(event, direction, serviceId, imgName) {
        event.preventDefault();

        fetch('https://localhost:44394/api/serviceimage/' + serviceId + '?currentImg=' + imgName + '&dir=' + direction)
            .then(results => {
                return results.json();
            })
            .then(data => {
                if (data.fileName) {
                    this.setState(
                    {
                        img_path: `https://localhost:44394/marketplaceassets/service/${data.serviceId}/${data.fileName}`,
                        img_name: data.fileName
                    })
                }
            })
    }

    render() {        
        return (
            <div className="service_gallery">
                <img src={this.state.img_path} alt="" />
                <a href='# ' className="prevBtn" onClick={(e) => { this.anotherImage(e, "prev", this.props.serviceId, this.state.img_name) }}>Prev</a>
                <a href='# ' className="nextBtn" onClick={(e) => { this.anotherImage(e, "next", this.props.serviceId, this.state.img_name) }}>Next</a>
            </div>
        );
    }
}

export default ServiceListGallery;