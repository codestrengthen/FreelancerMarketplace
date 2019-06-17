import React, { Component } from 'react';

import './Category.css';

class Category extends Component {
    constructor() {
        super();
        this.state = {
            categories: []
        };
    }

    componentDidMount() {
        fetch('https://localhost:44394/api/category/GetCategories')
            .then(results => {
                return results.json();
            })
            .then(data => {
                let cats = data.map((cat) => {
                    return (
                        <div id={cat.categoryId} key={cat.categoryId}
                            className={cat.parentCategoryId != null ? 'children' : null}>
                            <p>{cat.categoryName}</p>
                        </div>
                )
            })
            this.setState({ categories: cats });
        });
    }

    render() {
        let categories = null;

        categories = <div className="container">{this.state.categories}</div>

        return categories;
    }
}

export default Category;